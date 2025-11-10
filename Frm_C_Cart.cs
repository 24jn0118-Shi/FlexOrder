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
    public partial class Frm_C_Cart : Form
    {
        public Frm_C_Cart()
        {
            InitializeComponent();
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            Frm_C_Payment form = new Frm_C_Payment();
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCCart_Load(object sender, EventArgs e)
        {
            dgvCart.Rows.Clear();

            dgvCart.Rows.Add(Properties.Resources.pizza, "Pizza", 2, "1000");
            dgvCart.Rows.Add(Properties.Resources.ice_cream, "Ice-Cream", 1, "250");
            
            tboxTotalPrice.Text = "1250";
        }
    }
}
