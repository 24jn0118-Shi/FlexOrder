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
        string selected_id = null;
        Boolean closeparent = false;
        Staff loginstaff;
        public Frm_S_StaffManagement(Staff loginstaff, Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.loginstaff = loginstaff;
        }
        private void Refresh_page() 
        {
            selected_id = null;
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
            Console.WriteLine(this.Text+": Page Refreshed");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit("Add",this);
            frmSStaffEdit.ShowDialog();
            Refresh_page();
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
                Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit(loginstaff, selected_id,this);
                frmSStaffEdit.ShowDialog();
                Refresh_page();
            }
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
                StaffTable staffTable = new StaffTable();
                Staff st = staffTable.GetStaffById(int.Parse(selected_id));
                if (st != null && st.is_manager) 
                {
                    MessageBox.Show("管理者のアカウントが削除できません", "エラー",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    DialogResult dret = MessageBox.Show("スタッフを削除しますか", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dret == DialogResult.Yes)
                    {
                        int cnt = staffTable.Delete(st.staff_id);
                        if (cnt > 0) 
                        {
                            MessageBox.Show(cnt+"件の店員アカウントを削除しました", "削除完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Refresh_page();
                    }
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
            Refresh_page();
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
