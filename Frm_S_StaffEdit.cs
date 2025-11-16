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
    public partial class Frm_S_StaffEdit : Form
    {
        String type;
        public Frm_S_StaffEdit(String type)
        {
            InitializeComponent();
            if (type == "Add")
            {
                lblTitle.Text = "店員追加";
            }
            else
            if (type == "Edit")
            {
                lblTitle.Text = "店員編集";
            }
            this.type = type;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
