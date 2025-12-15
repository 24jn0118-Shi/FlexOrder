using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FlexOrder
{
    public partial class Frm_C_Menu : Form
    {
        Dictionary<string, int> langMap = new Dictionary<string, int>()
        {
            { "ja", 1 },
            { "en", 2 },
            { "zh", 3 },
            { "ru", 4 }
        };

        int currentLangNo = 1;
        bool vege = false;
        string ordertype;

        private Dictionary<string, List<Goods>> _allGoodsCache = new Dictionary<string, List<Goods>>();

        public Order currentOrder = new Order();

        private bool isDragging = false;
        private Point lastMousePosition = Point.Empty;
        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 15;
        public Frm_C_Menu(bool istakeout, string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            currentOrder.is_takeout = istakeout;
            SetupCustomTabs();
        }
        public Frm_C_Menu(Order order, string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            currentOrder = order;
            SetupCustomTabs();
        }
        private void SetupCustomTabs()
        {
            tbcntMenu.Alignment = TabAlignment.Left;
            tbcntMenu.Multiline = true;
            tbcntMenu.SizeMode = TabSizeMode.Fixed;
            tbcntMenu.ItemSize = new Size(60, 160);
            tbcntMenu.DrawMode = TabDrawMode.OwnerDrawFixed;
            tbcntMenu.DrawItem += TabControl1_DrawItem;
            tbcntMenu.SelectedIndexChanged += TbcntMenu_SelectedIndexChanged;
        }
        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabPage tabPage = tabControl.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.Control), e.Bounds);

            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };

            Brush textBrush = e.State == DrawItemState.Selected ? Brushes.Blue : Brushes.Black;
            e.Graphics.DrawString(tabPage.Text, e.Font, textBrush, e.Bounds, sf);
        }
        private void FrmCMenu_Load(object sender, EventArgs e)
        {
            txtKaikei.Text = "¥ 0";
            dgvOrderList.DefaultCellStyle.SelectionBackColor = dgvOrderList.DefaultCellStyle.BackColor;
            dgvOrderList.DefaultCellStyle.SelectionForeColor = dgvOrderList.DefaultCellStyle.ForeColor;
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;
            if (langMap.TryGetValue(currentLang, out int result))
                currentLangNo = result;

            LoadGroupsTabs();
            tbcntMenu.SelectedIndex = -1;
            tbcntMenu.SelectedIndex = 0;
            RefreshCart();
        }
        private void BindTouchScrollEvents(FlowLayoutPanel panel)
        {
            panel.MouseDown -= flowLayoutPanelMenuRecommend_MouseDown;
            panel.MouseMove -= flowLayoutPanelMenuRecommend_MouseMove;
            panel.MouseUp -= flowLayoutPanelMenuRecommend_MouseUp;

            panel.MouseDown += flowLayoutPanelMenuRecommend_MouseDown;
            panel.MouseMove += flowLayoutPanelMenuRecommend_MouseMove;
            panel.MouseUp += flowLayoutPanelMenuRecommend_MouseUp;
        }
        private void LoadGroupsTabs()
        {
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            List<GoodsGroup> groups = goodsGroupTable.GetAllAvailableGroup(currentLangNo);

            foreach (GoodsGroup group in groups)
            {
                string groupCode = group.group_code;

                TabPage tab = new TabPage(group.group_name);
                FlowLayoutPanel panel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };
                tab.Controls.Add(panel);
                tab.Tag = groupCode;
                tbcntMenu.TabPages.Add(tab);
                BindTouchScrollEvents(panel);
            }
        }
        private void TbcntMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsForTab(tbcntMenu.SelectedTab);
            ApplyVegetarianFilterToTab(tbcntMenu.SelectedTab);
        }
        private void LoadProductsForTab(TabPage tab) 
        {
            if (tab == null) return;
            FlowLayoutPanel panel;
            string groupCode;
            if (tab == tbcntMenu.TabPages[0])
            {
                panel = flowLayoutPanelMenuRecommend;
                groupCode = "RECOMMEND";
            }
            else
            {
                if (tab.Controls.Count == 0 || !(tab.Controls[0] is FlowLayoutPanel)) return;
                panel = (FlowLayoutPanel)tab.Controls[0];
                groupCode = tab.Tag as string;
            }
            if (panel.Controls.Count > 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(groupCode) || _allGoodsCache.ContainsKey(groupCode))
            {
            }
            else
            {
                GoodsTable goodsTable = new GoodsTable();
                List<Goods> goodsList = (groupCode == "RECOMMEND")
                    ? goodsTable.GetRecommendGoods(currentLangNo)
                    : goodsTable.GetGoodsByGroup(currentLangNo, groupCode);

                if (goodsList != null)
                {
                    _allGoodsCache[groupCode] = goodsList;
                }
            }
            if (_allGoodsCache.TryGetValue(groupCode, out List<Goods> cachedList))
            {
                foreach (Goods good in cachedList)
                {
                    ProductItem product = new ProductItem
                    {
                        Id = good.goods_id,
                        ProductTitle = good.goods_name,
                        ProductPrice = "¥ " + good.goods_price.ToString("N0")
                    };
                    string imagePath = ImagePro.GetImagePath(good.goods_image_filename);
                    if (File.Exists(imagePath))
                    {
                        using (var tempImage = Image.FromFile(imagePath))
                        {
                            product.ProductImage = new Bitmap(tempImage);
                        }
                    }
                    else
                    {
                        product.ProductImage = Properties.Resources.noimage;
                    }

                    product.ProductClicked += ProductItem_ProductClicked;
                    panel.Controls.Add(product);
                }
            }
        }
        private void ApplyVegetarianFilterToTab(TabPage tab)
        {
            FlowLayoutPanel panel;
            string groupCode;

            if (tab == tbcntMenu.TabPages[0])
            {
                panel = flowLayoutPanelMenuRecommend;
                groupCode = "RECOMMEND";
            }
            else
            {
                if (tab == null || tab.Controls.Count == 0 || !(tab.Controls[0] is FlowLayoutPanel)) return;
                panel = (FlowLayoutPanel)tab.Controls[0];
                groupCode = tab.Tag as string;
            }

            if (panel.Controls.Count == 0) return;

            if (_allGoodsCache.TryGetValue(groupCode, out List<Goods> cachedList))
            {
                foreach (Control control in panel.Controls)
                {
                    if (control is ProductItem productItem)
                    {
                        Goods good = cachedList.FirstOrDefault(g => g.goods_id == productItem.Id);

                        if (good != null)
                        {
                            bool shouldBeVisible = !vege || good.is_vegetarian;
                            productItem.Visible = shouldBeVisible;
                        }
                    }
                }
            }
        }
        private void ProductItem_ProductClicked(ProductItem productItem)
        {
            int initialQuantity = 1;
            var existingItem = currentOrder.orderdetaillist.FirstOrDefault(item => item.goods_id == productItem.Id);

            if (existingItem != null)
            {
                initialQuantity = existingItem.quantity;
            }
            using (Frm_C_GoodsDetail detailForm = new Frm_C_GoodsDetail(productItem.Id))
            {
                DialogResult result = detailForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    OrderDetail newDetail = detailForm.AddedItem;

                    if (newDetail != null && newDetail.quantity >= 0)
                    {
                        currentOrder.AddItem(
                            newDetail.goods_id,
                            newDetail.goods_name,
                            newDetail.price,
                            newDetail.quantity
                        );
                    }
                    RefreshCart();
                }
            }
        }
        private void RefreshCart()
        {
            int firstVisibleRowIndex = -1;
            if (dgvOrderList.Rows.Count > 0 && dgvOrderList.FirstDisplayedScrollingRowIndex >= 0)
            {
                firstVisibleRowIndex = dgvOrderList.FirstDisplayedScrollingRowIndex;
            }
            dgvOrderList.Rows.Clear();
            if (currentOrder.orderdetaillist == null || currentOrder.orderdetaillist.Count == 0)
            {
                txtKaikei.Text = "¥ " + "0";
                btnConfirm.Enabled = false;
                return;
            }
            foreach (var item in currentOrder.orderdetaillist)
            {
                int subtotal = item.Subtotal;

                dgvOrderList.Rows.Add(
                    item.goods_name,
                    "➖",
                    item.quantity,
                    "➕",
                    subtotal.ToString("N0"),
                    item.goods_id
                );
            }
            dgvOrderList.ClearSelection();
            txtKaikei.Text = "¥ "+currentOrder.TotalPrice.ToString("N0");
            if (firstVisibleRowIndex >= 0 && firstVisibleRowIndex < dgvOrderList.Rows.Count)
            {
                try
                {
                    dgvOrderList.FirstDisplayedScrollingRowIndex = firstVisibleRowIndex;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                }
            }
            if (currentOrder.orderdetaillist.Count > 0 && currentOrder.TotalPrice > 0)
            {
                btnConfirm.Enabled = true;
            }
        }
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            currentOrder.RemoveZeros();
            if (ordertype != "edit") 
            {
                using (Frm_C_Cart form = new Frm_C_Cart(ordertype, currentOrder))
                {
                    DialogResult result = form.ShowDialog();
                    if (form.closeparent)
                    {
                        this.Close();
                    }
                    if (result == DialogResult.Cancel || result == DialogResult.None)
                    {
                        this.currentOrder = form.currentOrder;
                        RefreshCart();
                    }
                }
            }
            else 
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ckbVeget_CheckedChanged(object sender, EventArgs e)
        {
            vege = ckbVeget.Checked;
            ApplyVegetarianFilterToTab(tbcntMenu.SelectedTab);
        }
        private void lblVeget_Click(object sender, EventArgs e)
        {
            ckbVeget.Checked = !ckbVeget.Checked;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            DialogResult dret = MessageBox.Show(lblConfirm2.Text, lblConfirm1.Text,
                                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dret == DialogResult.Yes)
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }
        private void dgvOrderList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || !(dgvOrderList.Columns[e.ColumnIndex] is DataGridViewButtonColumn))
            {
                return;
            }

            int minusColumnIndex = 1;
            int plusColumnIndex = 3;
            var itemToModify = currentOrder.orderdetaillist[e.RowIndex];

            if (e.ColumnIndex == plusColumnIndex)
            {

                currentOrder.PlusMinus(itemToModify.goods_id, 1);
            }
            else if (e.ColumnIndex == minusColumnIndex)
            {
                currentOrder.PlusMinus(itemToModify.goods_id, -1);
            }
            RefreshCart();
        }
        private void flowLayoutPanelMenuRecommend_MouseUp(object sender, MouseEventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (panel == null) return;

            isDragging = false;

            panel.Capture = false;
        }
        private void flowLayoutPanelMenuRecommend_MouseDown(object sender, MouseEventArgs e)
        {
            FlowLayoutPanel panel = sender as FlowLayoutPanel;
            if (panel == null) return;

            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastMousePosition = e.Location;

                panel.Capture = true;
            }
        }
        private void flowLayoutPanelMenuRecommend_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                FlowLayoutPanel panel = sender as FlowLayoutPanel;
                if (panel == null)
                {
                    Control ctrl = sender as Control;
                    if (ctrl != null && ctrl.Parent is FlowLayoutPanel flp)
                    {
                        panel = flp;
                    }
                }
                if (panel == null || !isDragging) return;

                int deltaY = e.Y - lastMousePosition.Y;

                Point currentScroll = panel.AutoScrollPosition;

                int newY = -currentScroll.Y - deltaY;

                panel.AutoScrollPosition = new Point(0, newY);

                lastMousePosition = e.Location;
                if (isDragging)
                {
                }
            }
        }
        private void dgvOrderList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggingDGV = true;
                lastMouseY = e.Y;
            }
        }
        private void dgvOrderList_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingDGV)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null || dgv.RowCount == 0) return;

                int deltaY = e.Y - lastMouseY;
                int rowsToScroll = deltaY / SCROLL_SENSITIVITY;

                if (rowsToScroll != 0)
                {
                    int currentFirstRow = dgv.FirstDisplayedScrollingRowIndex;

                    int newFirstRow = currentFirstRow - rowsToScroll;

                    newFirstRow = Math.Max(0, newFirstRow);
                    if (newFirstRow != currentFirstRow)
                    {
                        dgv.FirstDisplayedScrollingRowIndex = newFirstRow;
                    }

                    lastMouseY += (rowsToScroll * SCROLL_SENSITIVITY);
                }
            }
        }
        private void dgvOrderList_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
        }
    }
}