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
    public partial class FrmCCart : Form
    {
        internal Form previousForm;
        public FrmCCart(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            FrmCPayment form = new FrmCPayment(this);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
