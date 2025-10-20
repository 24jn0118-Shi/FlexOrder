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
    public partial class FrmCPayment : Form
    {
        internal Form previousForm;
        public FrmCPayment(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            FrmCEnd form = new FrmCEnd(this);
            form.ShowDialog();
        }
    }
}
