using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
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
            LoadProductsForTab(tbcntMenu.SelectedTab);
        }

        private void LoadGroupsTabs()
        {
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            List<GoodsGroup> groups = goodsGroupTable.GetAllAvailableGroup(currentLangNo);

            foreach (GoodsGroup group in groups)
            {
                string groupCode = group.group_code;
                if (groupCode == "flowLayoutPanelMenuRecommend") continue;

                TabPage tab = new TabPage(group.group_name);
                FlowLayoutPanel panel = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true
                };
                tab.Controls.Add(panel);
                tab.Tag = groupCode;
                tbcntMenu.TabPages.Add(tab);
            }
        }

        private void TbcntMenu_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProductsForTab(tbcntMenu.SelectedTab);
        }

        private void LoadProductsForTab(TabPage tab)
        {
            if (tab == null) return;

            FlowLayoutPanel panel = (tab == tbcntMenu.TabPages[0]) ? flowLayoutPanelMenuRecommend : (FlowLayoutPanel)tab.Controls[0];

            panel.Controls.Clear();

            string groupCode = tab.Tag as string;
            GoodsTable goodsTable = new GoodsTable();
            List<Goods> goodsList;

            if (groupCode == "flowLayoutPanelMenuRecommend" || tab == tbcntMenu.TabPages[0])
            {
                goodsList = goodsTable.GetRecommendGoods(currentLangNo);
            }
            else
            {
                goodsList = goodsTable.GetGoodsByGroup(currentLangNo, groupCode);
            }

            foreach (Goods good in goodsList)
            {
                if (vege && !good.is_vegetarian) continue;

                ProductItem product = new ProductItem
                {
                    Code = good.goods_code,
                    ProductTitle = good.goods_name,
                    ProductPrice = "¥ " + good.goods_price.ToString("N0")
                };

                ImagePro imagePro = new ImagePro();
                string imagePath = imagePro.GetImagePath(good.goods_image);

                if (File.Exists(imagePath))
                {
                    using (FileStream fs = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                    {
                        product.ProductImage = Image.FromStream(fs);
                    }
                }

                product.ProductClicked += ProductItem_ProductClicked;
                panel.Controls.Add(product);
            }
        }

        private void ProductItem_ProductClicked(ProductItem productItem)
        {
            Frm_C_GoodsDetail frm = new Frm_C_GoodsDetail(productItem.Code);
            frm.ShowDialog();
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
            LoadProductsForTab(tbcntMenu.SelectedTab);
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