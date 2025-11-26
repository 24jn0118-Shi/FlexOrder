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
        Dictionary<string, int> langMap = new Dictionary<string, int>()
        {
            { "ja", 1 },
            { "en", 2 },
            { "zh", 3 },
            { "ru", 4 }
        };
        int currentLangNo = 1;
        bool vege = false;
        String ordertype;
        public Frm_C_Menu(String ordertype)
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
            Frm_C_Cart form = new Frm_C_Cart(ordertype);
            form.ShowDialog();
        }
        private void ProductItem_ProductClicked(ProductItem productItem)
        {
            //MessageBox.Show(ProductTitle + " " + ProductPrice, Code);
            Frm_C_GoodsDetail frm_C_GoodsDetail = new Frm_C_GoodsDetail(productItem.Code);
            frm_C_GoodsDetail.ShowDialog();
            Refresh_page();
        }
        private void Refresh_page() 
        {
            Console.WriteLine(this.Text + ": Page Refreshed");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadGoods() 
        {
            GoodsTable goodsTable = new GoodsTable();
            List<Goods> goodslist = goodsTable.GetRecommendGoods(currentLangNo);
            foreach (Goods good in goodslist)
            {
                if (vege && !good.is_vegetarian)
                {
                    continue;
                }
                ProductItem product = new ProductItem();
                product.Code = good.goods_code;
                product.ProductTitle = good.goods_name;
                product.ProductPrice = "¥ " + good.goods_price.ToString("N0");
                var img = (Image)Properties.Resources.ResourceManager.GetObject(good.goods_image);
                product.ProductImage = img;
                product.ProductClicked += ProductItem_ProductClicked;
                flowLayoutPanelMenu.Controls.Add(product);
            }
        }
        private void FrmCMenu_Load(object sender, EventArgs e)
        {
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;
            if (langMap.TryGetValue(currentLang, out int result))
            {
                currentLangNo = result;
            }

            /*ProductItem product1 = new ProductItem();
            product1.ProductTitle = "Pizza";
            product1.ProductPrice = "¥ 500";
            //product1.ProductImage = global::FlexOrder.Properties.Resources.pizza;
            var img1 = (Image)Properties.Resources.ResourceManager.GetObject("pizza");
            product1.ProductImage = img1;
            product1.ProductClicked += ProductItem_ProductClicked;
            //flowLayoutPanelMenu.Controls.Add(product1);

            ProductItem product2 = new ProductItem();
            product2.ProductTitle = "Icecream";
            product2.ProductPrice = "¥ 250";
            //product2.ProductImage = global::FlexOrder.Properties.Resources.ice_cream;
            var img2 = (Image)Properties.Resources.ResourceManager.GetObject("ice_cream");
            product2.ProductImage = img2;
            product2.ProductClicked += ProductItem_ProductClicked;
            //flowLayoutPanelMenu.Controls.Add(product2);
            */
            LoadGoods();
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }


        private void ckbVeget_CheckedChanged(object sender, EventArgs e)
        {
            vege = ckbVeget.Checked;
            flowLayoutPanelMenu.Controls.Clear();
            LoadGoods();
        }

        private void lblVeget_Click(object sender, EventArgs e)
        {
            ckbVeget.Checked = !ckbVeget.Checked;
        }
    }
}
