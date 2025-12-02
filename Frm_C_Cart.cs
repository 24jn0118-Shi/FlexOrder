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
        public Order currentOrder;
        public Frm_C_Cart(string ordertype, Order currentOrder)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            this.currentOrder = currentOrder;
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
            dgvCart.MultiSelect = false;
            dgvCart.AutoGenerateColumns = false;

            //dgvCart.Rows.Add(Properties.Resources.ResourceManager.GetObject("pizza"), "Pizza", 2, "500",1000.ToString("N0"));
            //dgvCart.Rows.Add(Properties.Resources.ResourceManager.GetObject("ice_cream"), "Ice-Cream", 1, "250","250");
            //tboxTotalPrice.Text = "1250";

            RefreshCart();
        }
        private void RefreshCart()
        {
            dgvCart.Rows.Clear();
            if (currentOrder.orderdetaillist == null || currentOrder.orderdetaillist.Count == 0)
            {
                tboxTotalPrice.Text = "0";
                return;
            }
            foreach (var item in currentOrder.orderdetaillist)
            {
                int subtotal = item.Subtotal;
                Image image;
                string imagePath = ImagePro.GetImagePath((item.goods_id.ToString())+".jpg");
                if (File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        image = new Bitmap(tempImage);
                    }
                }
                else
                {
                    image = Properties.Resources.noimage;
                }
                dgvCart.Rows.Add(
                    image,
                    item.goods_name,
                    item.price,
                    item.quantity,
                    subtotal.ToString("N0")
                );
            }
            dgvCart.ClearSelection();
            tboxTotalPrice.Text = "¥ " + currentOrder.TotalPrice.ToString("N0");
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

        private void Frm_C_Cart_FormClosing(object sender, FormClosingEventArgs e)
        {
            //currentOrder = new Order();
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
