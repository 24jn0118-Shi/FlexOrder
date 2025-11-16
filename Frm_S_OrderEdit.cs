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
    public partial class Frm_S_OrderEdit : Form
    {
        public Frm_S_OrderEdit()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu();
            frm_C_Menu.ShowDialog();
        }
    }
}
