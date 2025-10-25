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
        public ProductItem()
        {
            InitializeComponent();
            this.pictureBox1.Click += ProductItem_Click;
            this.labeltitle1.Click += ProductItem_Click;
            this.labelprice1.Click += ProductItem_Click;
        }

        public string ProductTitle
        {
            get { return labeltitle1.Text; }
            set { labeltitle1.Text = value; }
        }

        public string ProductPrice
        {
            get { return labelprice1.Text; }
            set { labelprice1.Text = value; }
        }

        public Image ProductImage
        {
            get { return pictureBox1.Image; }
            set { pictureBox1.Image = value; }
        }

        private void ProductItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(ProductTitle + " " + ProductPrice, "Hi Test Title");
        }
    }
}
