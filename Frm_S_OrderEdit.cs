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
    public partial class Frm_S_OrderEdit : Form
    {
        int orderid;
        public Frm_S_OrderEdit(int orderid)
        {
            InitializeComponent();
            this.orderid = orderid;
            lblOrderNo.Text = orderid.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu("add");
            frm_C_Menu.ShowDialog();
        }
    }
}
