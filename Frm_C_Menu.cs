using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

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
        private bool _controlsCreated = false;
        public Frm_C_Menu(string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
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
            //tbcntMenu.SelectedIndexChanged += TbcntMenu_SelectedIndexChanged;
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
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;
            if (langMap.TryGetValue(currentLang, out int result))
                currentLangNo = result;

            LoadGroupsTabs();
            LoadProductsForTabs();
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
                Console.WriteLine(tab.Tag + " Added");
                tbcntMenu.TabPages.Add(tab);
            }
        }

        private void TbcntMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //LoadProductsForTab(tbcntMenu.SelectedTab);
            //Console.WriteLine(tbcntMenu.SelectedTab.Tag + " Selected");
        }
        private void LoadProductsForTabs()
        {
            if (_controlsCreated) return;
            if (tbcntMenu.TabPages.Count == 0) return;
            GoodsTable goodsTable = new GoodsTable();
            _allGoodsCache.Clear();
            foreach (TabPage tab in tbcntMenu.TabPages)
            {
                List<Goods> goodsList = null;
                string groupCode = null;

                if (tab == tbcntMenu.TabPages[0])
                {
                    goodsList = goodsTable.GetRecommendGoods(currentLangNo);
                    groupCode = "RECOMMEND";
                }
                else
                {
                    groupCode = tab.Tag as string;
                    if (string.IsNullOrEmpty(groupCode)) continue;
                    goodsList = goodsTable.GetGoodsByGroup(currentLangNo, groupCode);
                }
                if (goodsList != null && !string.IsNullOrEmpty(groupCode))
                {
                    _allGoodsCache[groupCode] = goodsList;
                }
            }
            CreateAllProductControls();
        }
        private void CreateAllProductControls()
        {
            if (_controlsCreated) return;
            foreach (TabPage tab in tbcntMenu.TabPages)
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
                    if (tab.Controls.Count == 0 || !(tab.Controls[0] is FlowLayoutPanel)) continue;
                    panel = (FlowLayoutPanel)tab.Controls[0];
                    groupCode = tab.Tag as string;
                }
                if (_allGoodsCache.TryGetValue(groupCode, out List<Goods> cachedList))
                {
                    foreach (Goods good in cachedList)
                    {
                        ProductItem product = new ProductItem
                        {
                            Code = good.goods_code,
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
                            product.ProductImage = Properties.Resources.testimage1; 
                        }
                        product.ProductClicked += ProductItem_ProductClicked;
                        panel.Controls.Add(product);
                    }
                }
            }
            _controlsCreated = true;
            ApplyVegetarianFilter();
        }
        private void ApplyVegetarianFilter()
        {
            if (!_controlsCreated) return;
            foreach (TabPage tab in tbcntMenu.TabPages)
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
                    if (tab.Controls.Count == 0 || !(tab.Controls[0] is FlowLayoutPanel)) continue;
                    panel = (FlowLayoutPanel)tab.Controls[0];
                    groupCode = tab.Tag as string;
                }
                if (_allGoodsCache.TryGetValue(groupCode, out List<Goods> cachedList))
                {
                    foreach (Control control in panel.Controls)
                    {
                        if (control is ProductItem productItem)
                        {
                            Goods good = cachedList.FirstOrDefault(g => g.goods_code == productItem.Code);

                            if (good != null)
                            {
                                bool shouldBeVisible = !vege || good.is_vegetarian;
                                productItem.Visible = shouldBeVisible;
                            }
                        }
                    }
                }
            }
        }
        private void ProductItem_ProductClicked(ProductItem productItem)
        {
            Frm_C_GoodsDetail frm = new Frm_C_GoodsDetail(productItem.Code);
            frm.ShowDialog();
            //この時点でCart dgvをrefreshする
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Frm_C_Cart form = new Frm_C_Cart(ordertype);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ckbVeget_CheckedChanged(object sender, EventArgs e)
        {
            vege = ckbVeget.Checked;
            ApplyVegetarianFilter();
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
    }
}