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
        public event Action<ProductItem> ProductClicked;

        int id;
        public Color DefaultColor;
        private readonly Color HoverColor = Color.LightGray;
        private readonly Color PressedColor = Color.LightSkyBlue;
        public ProductItem()
        {
            InitializeComponent();
            DefaultColor = this.BackColor;
            this.ptbImage.Click += ProductItem_Click;
            this.lblTitle.Click += ProductItem_Click;
            this.lblPrice.Click += ProductItem_Click;
            this.ptbImage.MouseEnter += ProductItem_MouseEnter;
            this.lblTitle.MouseEnter += ProductItem_MouseEnter;
            this.lblPrice.MouseEnter += ProductItem_MouseEnter;
            this.ptbImage.MouseLeave += ProductItem_MouseLeave;
            this.lblTitle.MouseLeave += ProductItem_MouseLeave;
            this.lblPrice.MouseLeave += ProductItem_MouseLeave;
            this.ptbImage.MouseDown += ProductItem_MouseDown;
            this.lblTitle.MouseDown += ProductItem_MouseDown;
            this.lblPrice.MouseDown += ProductItem_MouseDown;
            this.MouseEnter += ProductItem_MouseEnter;
            this.MouseLeave += ProductItem_MouseLeave;
            this.MouseDown += ProductItem_MouseDown;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
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
            ProductClicked?.Invoke(this);
        }
        private void ProductItem_MouseEnter(object sender, EventArgs e)
        {
            this.BackColor = HoverColor;
        }
        private void ProductItem_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = DefaultColor;
        }
        private void ProductItem_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.BackColor = PressedColor;
            }
        }
    }
}
