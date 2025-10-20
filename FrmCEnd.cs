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
    public partial class FrmCEnd : Form
    {
        internal Form previousForm;
        public FrmCEnd(Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }
    }
}
