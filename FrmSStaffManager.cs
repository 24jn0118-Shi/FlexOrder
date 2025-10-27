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
    public partial class FrmSStaffManager : Form
    {
        public FrmSStaffManager()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmSStaffEdit frmSStaffEdit = new FrmSStaffEdit();
            frmSStaffEdit.ShowDialog();
        }
    }
}
