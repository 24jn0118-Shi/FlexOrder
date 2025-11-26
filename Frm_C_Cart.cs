using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_Cart : Form
    {
        string ordertype;
        public Frm_C_Cart(string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Frm_C_Payment form = new Frm_C_Payment(ordertype);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCCart_Load(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();

            //dgvCart.Rows.Add(Properties.Resources.pizza, "Pizza", 2, "1000");
            //dgvCart.Rows.Add(Properties.Resources.ice_cream, "Ice-Cream", 1, "250");

            /*ImagePro imagePro = new ImagePro();
            String image = imagePro.GetImagePath(good.goods_image);
            using (FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read))
            {
                Image img = Image.FromStream(fs);
                product.ProductImage = img;
            }*/

            dgvCart.Rows.Add(Properties.Resources.ResourceManager.GetObject("pizza"), "Pizza", 2, "1000");
            dgvCart.Rows.Add(Properties.Resources.ResourceManager.GetObject("ice_cream"), "Ice-Cream", 1, "250");

            tboxTotalPrice.Text = "1250";
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
