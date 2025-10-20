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
    public partial class FrmCMenu : Form
    {
        internal Form previousForm;
        public FrmCMenu(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            FrmCCart form = new FrmCCart(this);
            form.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
