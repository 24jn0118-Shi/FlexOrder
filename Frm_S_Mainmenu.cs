using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_S_Mainmenu : Form
    {
        Staff staff;
        public Frm_S_Mainmenu(Staff staff)
        {
            InitializeComponent();
            this.staff = staff;
            if (staff.is_manager)
            {
                btnStaffManagement.Enabled = true;
                btnSalesStatistics.Enabled = true;
            }
        }

        private void btnOrderManagement_Click(object sender, EventArgs e)
        {
            Frm_S_OrderManagement frm_S_OrderManagement = new Frm_S_OrderManagement(staff);
            frm_S_OrderManagement.ShowDialog();
        }
        private void btnMenuManagement_Click(object sender, EventArgs e)
        {
            Frm_S_MenuManagement frm_S_MenuManagement = new Frm_S_MenuManagement(staff);
            frm_S_MenuManagement.ShowDialog();
        }
        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            Frm_S_StaffManagement frm_S_StaffManagement = new Frm_S_StaffManagement(staff, this);
            frm_S_StaffManagement.ShowDialog();
        }
        private void btnSalesStatistics_Click(object sender, EventArgs e)
        {
            Frm_S_SalesStatistics frm_S_SalesStatistics = new Frm_S_SalesStatistics();
            frm_S_SalesStatistics.ShowDialog();
        }

        private void Frm_S_Mainmenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = "ようこそ、" + staff.staff_lastname + " " + staff.staff_firstname;
            //ImagePro.CheckAndCacheAllImages(true);
            ImagePro.CheckAndCacheAllImages(false);
        }

        private void Frm_S_Mainmenu_KeyPress(object sender, KeyPressEventArgs e)
        {
            char keyChar = Char.ToLower(e.KeyChar);
            if (keyChar == 'u')
            {
                ImagePro.CheckAndCacheAllImages(true);
            }
        }
    }
}
