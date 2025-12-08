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
        int total;
        public bool closeparent = false;
        public Frm_C_Payment(string ordertype, Order currentOrder)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            this.currentOrder = currentOrder;
            total = currentOrder.TotalPrice; 
            lblTotal.Text = "¥ " + total.ToString("N0");
        }
        public Frm_C_Payment(string ordertype, int total)
        {
            InitializeComponent();
            this.ordertype = ordertype;
            this.total = total;
            lblTotal.Text = "¥ " + total.ToString("N0");
            
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            GoPay("cash");
        }

        private void btnEMoney_Click(object sender, EventArgs e)
        {
            GoPay("em");
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            GoPay("card");
        }

        private void GoPay(string paytype) 
        {
            Frm_C_Payment2 form = new Frm_C_Payment2(paytype, total);
            form.ShowDialog();
            
            if (form.DialogResult == DialogResult.OK)
            {
                OrderTable orderTable = new OrderTable();
                if (ordertype != "edit") 
                { 
                    
                    orderTable.InsertNewOrder(currentOrder);
                    if (paytype == "card" && form.result.ToString() != "")
                    {
                        MessageBox.Show(form.result.ToString(), "カード決済結果");
                    }

                    if (ordertype == "in" || ordertype == "out")
                    {
                        Frm_C_End formend = new Frm_C_End(ordertype);
                        formend.ShowDialog();
                    }
                    else
                    {
                        closeparent = true;
                        this.Close();
                    }
                }
                else 
                {
                    closeparent = true;
                    this.Close();
                }

            }
        }

        private void Frm_C_Payment_Load(object sender, EventArgs e)
        {
            if (ordertype == "add") 
            {
                btnCreditCard.Visible = false;
                btnEMoney.Visible = false;
            }
        }
    }
}
