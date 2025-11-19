using FlexOrderLibrary;
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
        String message;
        int id = 0;
        Boolean change_password = false;
        Form parent;
        Boolean closeparent = false;
        Staff staff;
        public Frm_S_StaffEdit(String message, Form parent)
        {
            InitializeComponent();
            this.message = message;
            this.parent = parent;
        }
        public Frm_S_StaffEdit(Staff staff, String message, Form parent)
        {
            InitializeComponent();
            this.message = message;
            this.parent = parent;
            this.staff = staff;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (change_password) 
            {
                txbPassword.ReadOnly = true;
                txbPassword.Text = "";
                txbPassword2.ReadOnly = true;
                txbPassword2.Text = "";
                btnChangePassword.Text = "パスワード変更をONにする";
                change_password = false;
            } 
            else 
            {
                txbPassword.ReadOnly = false;
                txbPassword2.ReadOnly = false;
                btnChangePassword.Text = "パスワード変更をOFFにする";
                change_password = true;
            }
        }
        private void Frm_S_StaffEdit_Load(object sender, EventArgs e)
        {
            if (message == "Add")
            {
                //this.type = "Add";
                lblTitle.Text = "店員追加";
                rbtnStaff.Checked = true;
            }
            else
            {
                //this.type = "Edit";
                lblTitle.Text = "店員編集";
                id = int.Parse(message);
                StaffTable staffTable = new StaffTable();
                Staff staff = staffTable.GetStaffById(id);
                txbID.Text = id.ToString();
                txbLastname.Text = staff.staff_lastname;
                txbFirstname.Text = staff.staff_firstname;
                if (staff.is_manager)
                {
                    rbtnAdmin.Checked = true;
                }
                else
                {
                    rbtnStaff.Checked = true;
                }
                txbPassword.ReadOnly = true;
                txbPassword2.ReadOnly = true;
                txbID.ReadOnly = true;
                btnChangePassword.Visible = true;
            }
        }

        private void Frm_S_StaffEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (closeparent) 
            {
                parent.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StaffTable staffTable = new StaffTable();

            if(staff != null && staff.staff_id == id)
            {
                closeparent = true;
            }
        }
    }
}
