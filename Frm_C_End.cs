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
        string ordertype;
        public Frm_C_End(string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_C_End_Load(object sender, EventArgs e)
        {
            timer1.Start();
            switch (ordertype) 
            {
                case "in":
                    lblOrderType.Text = lblIn.Text;
                    break;
                case "out":
                    lblOrderType.Text = lblOut.Text;
                    break;
                default:
                    break;
            }

        }
        private void Frm_C_End_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Enabled = false;
            if (ordertype == "in" || ordertype == "out") 
            {
                Application.Restart();
                Environment.Exit(0);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
