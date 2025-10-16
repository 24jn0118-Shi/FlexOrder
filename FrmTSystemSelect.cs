using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder_Prototype
{
    
    public partial class FrmTSystemSelect : Form
    {
        int cnt = 0;
        public FrmTSystemSelect()
        {
            InitializeComponent();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            FrmCIndex form = new FrmCIndex();
            form.ShowDialog();
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            FrmSLogin form = new FrmSLogin();
            form.ShowDialog();
        }
    }
}
