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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {dataGridView1.Rows.Add(Properties.Resources.pizza, "Pizza", 1, "800");

        }

        private void FrmCCart_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(Properties.Resources.pizza, "Pizza", 2, "1000");
            dataGridView1.Rows.Add(Properties.Resources.ice_cream, "Ice-Cream", 1, "250");
            tboxTotalPrice.Text = "1250";
        }
    }
}
