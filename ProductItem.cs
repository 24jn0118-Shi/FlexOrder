using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class ProductItem : UserControl
    {
        String code;
        public ProductItem()
        {
            InitializeComponent();
            this.ptbImage.Click += ProductItem_Click;
            this.lblTitle.Click += ProductItem_Click;
            this.lblPrice.Click += ProductItem_Click;
        }
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string ProductTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }

        public string ProductPrice
        {
            get { return lblPrice.Text; }
            set { lblPrice.Text = value; }
        }

        public Image ProductImage
        {
            get { return ptbImage.Image; }
            set { ptbImage.Image = value; }
        }

        private void ProductItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(ProductTitle + " " + ProductPrice, Code);
            Frm_C_GoodsDetail frm_C_GoodsDetail = new Frm_C_GoodsDetail(Code);
            frm_C_GoodsDetail.ShowDialog();
            
        }
    }
}
