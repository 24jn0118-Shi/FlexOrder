using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace FlexOrder
{
    public partial class Frm_C_Menu : Form
    {
        string currentLang;
        int currentLangNo = 1;
        public Frm_C_Menu()
        {
            InitializeComponent();
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
        }

        private void TabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabControl tabControl = (TabControl)sender;
            TabPage tabPage = tabControl.TabPages[e.Index];
            e.Graphics.FillRectangle(new SolidBrush(SystemColors.Control), e.Bounds);

            StringFormat sf = new StringFormat();
            sf.Alignment = StringAlignment.Center;
            sf.LineAlignment = StringAlignment.Center;

            Brush textBrush = e.State == DrawItemState.Selected ?
                Brushes.Blue : Brushes.Black;

            e.Graphics.DrawString(tabPage.Text, e.Font, textBrush, e.Bounds, sf);
        }
  

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Frm_C_Cart form = new Frm_C_Cart();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbpclass1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCMenu_Load(object sender, EventArgs e)
        {
            currentLang = Thread.CurrentThread.CurrentUICulture.Name;
            switch (currentLang){ 
                case "ja":
                    currentLangNo = 1;
                    break;
                case "en":
                    currentLangNo = 2;
                    break;
                case "zh":
                    currentLangNo = 3;
                    break;
                case "ru":
                    currentLangNo = 4;
                    break;
            }

            ProductItem product1 = new ProductItem();
            product1.ProductTitle = "Pizza";
            product1.ProductPrice = "¥ 500";
            //product1.ProductImage = global::FlexOrder.Properties.Resources.pizza;
            var img1 = (Image)Properties.Resources.ResourceManager.GetObject("pizza");
            product1.ProductImage = img1;
            //flowLayoutPanelMenu.Controls.Add(product1);

            ProductItem product2 = new ProductItem();
            product2.ProductTitle = "Icecream";
            product2.ProductPrice = "¥ 250";
            //product2.ProductImage = global::FlexOrder.Properties.Resources.ice_cream;
            var img2 = (Image)Properties.Resources.ResourceManager.GetObject("ice_cream");
            product2.ProductImage = img2;
            //flowLayoutPanelMenu.Controls.Add(product2);

            GoodsTable goodsTable = new GoodsTable();
            List<Goods> goodslist = goodsTable.GetRecommendGoodsByLanguage(currentLangNo);
            foreach (Goods good in goodslist) 
            {
                ProductItem product = new ProductItem();
                product.ProductTitle = good.goods_name;
                product.ProductPrice = "¥ " + good.goods_price.ToString();
                var img = (Image)Properties.Resources.ResourceManager.GetObject(good.goods_image);
                product.ProductImage = img;
                flowLayoutPanelMenu.Controls.Add(product);
            }
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
