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
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace FlexOrder
{
    public partial class Frm_S_StaffManagement : Form
    {
        Form parent;
        String selected_id = null;
        Boolean closeparent = false;
        Staff staff;
        public Frm_S_StaffManagement(Staff staff, Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.staff = staff;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit("Add",this);
            frmSStaffEdit.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (selected_id is null)
            {
                MessageBox.Show("スタッフを選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit(staff, selected_id,this);
                frmSStaffEdit.ShowDialog();
            }
            //Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit("Edit");
            //frmSStaffEdit.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selected_id is null)
            {
                MessageBox.Show("スタッフを選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                DialogResult dret = MessageBox.Show("スタッフを削除しますか", "確認",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {

                }


            }
                
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_StaffManagement_Load(object sender, EventArgs e)
        {
            dgvStaff.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvStaff.MultiSelect = false;
            dgvStaff.AutoGenerateColumns = false;
            StaffTable staffTable = new StaffTable();
            DataTable table = staffTable.GetAllStaff();
            table.Columns.Add("str_is_manager", typeof(string));
            foreach (DataRow row in table.Rows)
            {
                bool isManager = Convert.ToBoolean(row["is_manager"]);
                row["str_is_manager"] = isManager ? "管理者" : "店員";
            }
            dgvStaff.DataSource = table;
            dgvStaff.ClearSelection();
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_id = dgvStaff.CurrentRow.Cells["staff_id"].Value.ToString();
        }

        private void Frm_S_StaffManagement_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            if (closeparent)
            {
                parent.Close();
            }
        }
    }
}
