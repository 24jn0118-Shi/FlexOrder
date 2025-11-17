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
    public partial class Frm_S_OrderManagement : Form
    {
        public Frm_S_OrderManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_C_Menu frm_C_Menu = new Frm_C_Menu();
            frm_C_Menu.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Frm_S_OrderEdit frm_S_OrderEdit = new Frm_S_OrderEdit();
            frm_S_OrderEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
