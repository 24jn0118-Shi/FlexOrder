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
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;
            if (langMap.TryGetValue(currentLang, out int result))
                currentLangNo = result;

            LoadGroupsTabs();
            tbcntMenu.SelectedIndex = -1;
            tbcntMenu.SelectedIndex = 0;
            //LoadProductsForTabs();
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
            LoadProductsForTab(tbcntMenu.SelectedTab);
            ApplyVegetarianFilterToTab(tbcntMenu.SelectedTab);
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
        private void LoadProductsForTab(TabPage tab) 
        {
            if (tab == null) return;

            FlowLayoutPanel panel;
            string groupCode;

            // 1. 确定 Panel 和 GroupCode
            if (tab == tbcntMenu.TabPages[0])
            {
                panel = flowLayoutPanelMenuRecommend;
                groupCode = "RECOMMEND";
            }
            else
            {
                // 确保 FlowLayoutPanel 已经创建（在 LoadGroupsTabs 中已完成）
                if (tab.Controls.Count == 0 || !(tab.Controls[0] is FlowLayoutPanel)) return;
                panel = (FlowLayoutPanel)tab.Controls[0];
                groupCode = tab.Tag as string;
            }

            // ⭐ 核心判断：如果面板中已经有控件，说明此 Tab 已加载过，直接返回。
            // 注意：即使面板中没有控件，groupCode 也是必须的。
            if (panel.Controls.Count > 0)
            {
                // 如果需要，这里可以调用 ApplyVegetarianFilter() 确保可见性正确
                return;
            }

            // ----------------------------------------------------
            // 2. 耗时操作：首次加载 Tab 时执行查询和创建
            // ----------------------------------------------------

            if (string.IsNullOrEmpty(groupCode) || _allGoodsCache.ContainsKey(groupCode))
            {
                // 如果 groupCode 无效或数据已在缓存中，则跳过数据库查询。
                // 但如果此 Tab 的控件尚未创建 (Controls.Count == 0)，则继续到步骤 3 使用缓存创建控件。
            }
            else
            {
                // 数据库查询：仅对当前 Tab 执行查询
                GoodsTable goodsTable = new GoodsTable();
                List<Goods> goodsList = (groupCode == "RECOMMEND")
                    ? goodsTable.GetRecommendGoods(currentLangNo)
                    : goodsTable.GetGoodsByGroup(currentLangNo, groupCode);

                if (goodsList != null)
                {
                    // ⭐ 缓存数据，供后续筛选使用
                    _allGoodsCache[groupCode] = goodsList;
                }
            }

            // ----------------------------------------------------
            // 3. 控件创建：从缓存中读取数据并创建 ProductItem
            // ----------------------------------------------------

            if (_allGoodsCache.TryGetValue(groupCode, out List<Goods> cachedList))
            {
                // 这里执行的是原 CreateAllProductControls 中针对单个 Tab 的逻辑
                foreach (Goods good in cachedList)
                {
                    // ... (创建 ProductItem 实例的代码保持不变) ...
                    ProductItem product = new ProductItem
                    {
                        Code = good.goods_code,
                        ProductTitle = good.goods_name,
                        ProductPrice = "¥ " + good.goods_price.ToString("N0")
                    };

                    // 假设 ImagePro.GetImagePath 使用了 good.goods_code
                    // 示例中使用 goods_image_filename，这里沿用您的字段名
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
    }
}