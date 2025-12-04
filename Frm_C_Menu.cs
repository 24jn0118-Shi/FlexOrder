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

        private Order currentOrder = new Order();

        private bool isDragging = false;
        private Point lastMousePosition = Point.Empty;
        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 50;
        public Frm_C_Menu(string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            SetupCustomTabs();
            if(ordertype == "in") 
            {
                currentOrder.is_takeout = false;
            } 
            else if(ordertype == "out")
            {
                currentOrder.is_takeout = true;
            }
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
            using (Frm_C_Cart form = new Frm_C_Cart(ordertype, currentOrder))
            {
                DialogResult result = form.ShowDialog();
                if (result == DialogResult.Cancel || result == DialogResult.None)
                {
                    this.currentOrder = form.currentOrder;
                    RefreshCart();
                }
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbVeget_CheckedChanged(object sender, EventArgs e)
        {
            vege = ckbVeget.Checked;
            //ApplyVegetarianFilter();  
            tbcntMenu.SelectedIndex = 0;
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

            int currentQuantity = itemToModify.quantity;

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
                    // 如果 sender 是 ProductItem，我们需要获取它的 Parent (即 FlowLayoutPanel)
                    Control ctrl = sender as Control;
                    if (ctrl != null && ctrl.Parent is FlowLayoutPanel flp)
                    {
                        panel = flp;
                    }
                }
                if (panel == null || !isDragging) return;

                // 计算鼠标/手指移动的距离 (Delta)
                int deltaY = e.Y - lastMousePosition.Y;

                // 获取当前的滚动位置
                Point currentScroll = panel.AutoScrollPosition;

                // 关键：更新 AutoScrollPosition
                // AutoScrollPosition 是负数，我们需要将 deltaY (移动方向) 反向应用到滚动位置上。
                // 向下拖动 (deltaY > 0) -> 滚动条应该向上移动 (滚动位置 Y 值减小)
                // 向上拖动 (deltaY < 0) -> 滚动条应该向下移动 (滚动位置 Y 值增大)
                int newY = -currentScroll.Y - deltaY;

                // 设置新的滚动位置
                panel.AutoScrollPosition = new Point(0, newY);

                // 更新上次的位置，准备迎接下一次移动
                lastMousePosition = e.Location;
                if (isDragging)
                {
                    // 计算鼠标/手指移动的距离 (Delta)
                    // 关键：这里需要使用 e.Location 减去 lastMousePosition，但 e.Location 可能是相对于 ProductItem 的
                    // 🚨 这一步很危险，因为坐标系可能不一致。我们采用更简单且安全的方式：
                    // 1. 在 MouseDown 时记录 FlowLayoutPanel 的坐标。
                    // 2. 在 MouseMove 时，将 ProductItem 的坐标转换为 FlowLayoutPanel 的坐标再计算 delta。

                    // **安全简化方案：在 ProductItem 中实现拖动标记，并让 FlowLayoutPanel 监听全局鼠标位置**
                    // 💡 重新思考，最简单的解决方案是：让 ProductItem 上的 MouseMove 只是更新它的 isDraggingOccurred 状态，
                    // 而 FlowLayoutPanel 滚动逻辑则保持不变，因为它已经绑定了事件。

                    // 让我们只在 ProductItem 内部做标记，不进行事件委托：

                    // 保持 Frm_C_Menu.FlowLayoutPanel_MouseMove 为 private，不改动。
                    // 保持 Frm_C_Menu 的 FlowLayoutPanel_MouseMove 逻辑不变。
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

                // 计算鼠标/手指移动的距离 (Delta)
                int deltaY = e.Y - lastMouseY;

                // --- 核心滚动逻辑 ---

                // 1. 计算要滚动的行数。使用 SCROLL_SENSITIVITY 来调整滚动速度。
                // 向下拖动 (deltaY > 0) -> 列表应该向上滚动 (索引增大)
                // 向上拖动 (deltaY < 0) -> 列表应该向下滚动 (索引减小)
                // 注意：deltaY 必须 *反向* 影响滚动索引。
                int rowsToScroll = deltaY / SCROLL_SENSITIVITY;

                // 只有当拖动距离达到敏感度阈值时才滚动
                if (rowsToScroll != 0)
                {
                    int currentFirstRow = dgv.FirstDisplayedScrollingRowIndex;

                    // 计算新的第一行索引
                    int newFirstRow = currentFirstRow - rowsToScroll; // 注意这里的减法实现了滚动方向反转

                    // 确保新索引在有效范围内 [0, MaxRowIndex]
                    newFirstRow = Math.Max(0, newFirstRow);
                    // 最大索引是 dgv.RowCount - 1，但如果设置的太大，会显示空白区域
                    // 所以通常只需要限制最小值为 0。

                    // 只有当索引实际发生变化时才设置
                    if (newFirstRow != currentFirstRow)
                    {
                        dgv.FirstDisplayedScrollingRowIndex = newFirstRow;
                    }

                    // 更新上次的位置，准备迎接下一次移动
                    // 使用 rowsToScroll * SCROLL_SENSITIVITY 来精确匹配滚动步长，防止累计误差
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