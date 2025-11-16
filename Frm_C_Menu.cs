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

namespace FlexOrder
{
    public partial class Frm_C_Menu : Form
    {
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
            ProductItem product1 = new ProductItem();
            product1.ProductTitle = "Pizza";
            product1.ProductPrice = "¥ 500";
            product1.ProductImage = global::FlexOrder.Properties.Resources.pizza;
            flowLayoutPanelMenu.Controls.Add(product1);

            ProductItem product2 = new ProductItem();
            product2.ProductTitle = "Icecream";
            product2.ProductPrice = "¥ 250";
            product2.ProductImage = global::FlexOrder.Properties.Resources.ice_cream;
            flowLayoutPanelMenu.Controls.Add(product2);
        }
    }
}
