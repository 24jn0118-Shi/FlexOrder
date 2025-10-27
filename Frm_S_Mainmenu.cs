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
    public partial class Frm_S_Mainmenu : Form
    {
        public Frm_S_Mainmenu()
        {
            InitializeComponent();
        }

        private void btnEmployeeManagement_Click(object sender, EventArgs e)
        {
            Frm_S_StaffManagement frmSStaffManager = new Frm_S_StaffManagement();
            frmSStaffManager.ShowDialog(this);
        }
    }
}
