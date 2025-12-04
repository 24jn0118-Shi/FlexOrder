using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_Payment : Form
    {
        string ordertype;
        private Order currentOrder;
        public Frm_C_Payment(string ordertype, Order currentOrder)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            this.currentOrder = currentOrder;
            lblTotal.Text = "¥ " + currentOrder.TotalPrice.ToString("N0");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Frm_C_Payment2 form = new Frm_C_Payment2(currentOrder.TotalPrice);
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK) 
            {
                OrderTable orderTable = new OrderTable();
                orderTable.InsertNewOrder(currentOrder);
                Frm_C_End formend = new Frm_C_End(ordertype);
                formend.ShowDialog();
            }

        }
    }
}
