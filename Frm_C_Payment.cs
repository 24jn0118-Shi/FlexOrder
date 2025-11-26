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
    public partial class Frm_C_Payment : Form
    {
        string ordertype;
        public Frm_C_Payment(string ordertype)
        {
            InitializeComponent();
            this.ordertype = ordertype;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            Frm_C_End form = new Frm_C_End(ordertype);
            form.ShowDialog();
        }
    }
}
