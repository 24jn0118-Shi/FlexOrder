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
    public partial class Frm_C_End : Form
    {
        String ordertype;
        public Frm_C_End(String ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }

        private void Frm_C_End_Load(object sender, EventArgs e)
        {
            switch (ordertype) 
            {
                case "in":
                    lblOrderType.Text = "店内でご利用のお客様です";
                    break;
                case "out":
                    lblOrderType.Text = "お持ち帰りのお客様です";
                    break;
                default:
                    break;

            }
        }
    }
}
