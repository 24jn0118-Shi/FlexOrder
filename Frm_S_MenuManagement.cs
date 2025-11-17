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
    public partial class Frm_S_MenuManagement : Form
    {
        public Frm_S_MenuManagement()
        {
            InitializeComponent();
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            Frm_S_MenuEdit frm_S_MenuEdit = new Frm_S_MenuEdit("Add");
            frm_S_MenuEdit.ShowDialog();
        }
        private void btnEditGoods_Click(object sender, EventArgs e)
        {
            Frm_S_MenuEdit frm_S_MenuEdit = new Frm_S_MenuEdit("Edit");
            frm_S_MenuEdit.ShowDialog();
        }
        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {

        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Frm_S_GoodsGroupManagement frm_S_GoodsGroupManagement = new Frm_S_GoodsGroupManagement();
            frm_S_GoodsGroupManagement.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
