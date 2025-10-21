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
    public partial class FrmCIndex : Form
    {
        public FrmCIndex()
        {
            InitializeComponent();
        }

        private void btnDinein_Click(object sender, EventArgs e)
        {
            FrmCMenu form = new FrmCMenu();
            form.ShowDialog();
        }
    }
}
