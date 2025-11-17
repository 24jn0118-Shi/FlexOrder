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
    public partial class Frm_S_StaffManagement : Form
    {
        public Frm_S_StaffManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit("Add");
            frmSStaffEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit("Edit");
            frmSStaffEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_StaffManagement_Load(object sender, EventArgs e)
        {
            dgvStaff.AutoGenerateColumns = false;
            StaffTable staffTable = new StaffTable();
            DataTable table = staffTable.GetAllStaff();
            /*foreach (DataRow row in table.Rows)
            {
                if (bool.Parse(row["is_manager"].ToString()))
                {
                    row["is_manager"] = "管理者";
                }
                else 
                {
                    row["is_manager"] = "店員";
                }

            }*/
            table.Columns.Add("str_is_manager", typeof(string));

            foreach (DataRow row in table.Rows)
            {
                bool isManager = Convert.ToBoolean(row["is_manager"]);
                row["str_is_manager"] = isManager ? "管理者" : "店員";
            }
            dgvStaff.DataSource = table;
            dgvStaff.ClearSelection();
        }
    }
}
