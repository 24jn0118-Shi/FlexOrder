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

        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 15;
        public Frm_S_StaffManagement(Staff loginstaff, Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            this.loginstaff = loginstaff;
        }
        private void Refresh_page() 
        {
            int firstVisibleRowIndex = -1;
            if (dgvStaff.Rows.Count > 0 && dgvStaff.FirstDisplayedScrollingRowIndex >= 0)
            {
                firstVisibleRowIndex = dgvStaff.FirstDisplayedScrollingRowIndex;
            }
            selected_id = null;
            StaffTable staffTable = new StaffTable();
            DataTable table = staffTable.GetAllStaff();
            table.Columns.Add("str_staff_accesslevel", typeof(string));
            foreach (DataRow row in table.Rows)
            {
                int accesslevel = Convert.ToInt32(row["staff_accesslevel"]);
                switch (accesslevel) 
                {
                    case 0:
                        row["str_staff_accesslevel"] = "一般店員";
                        break;

                    case 1:
                        row["str_staff_accesslevel"] = "店長";
                        break;
                    case 9:
                        if (loginstaff.staff_accesslevel < 9) 
                        {
                            row.Delete();
                            continue;
                        }
                        row["str_staff_accesslevel"] = "IT管理者";
                        break;
                    default:
                        break;
                }
            }
            dgvStaff.DataSource = table;
            dgvStaff.ClearSelection();
            if (firstVisibleRowIndex >= 0 && firstVisibleRowIndex < dgvStaff.Rows.Count)
            {
                try
                {
                    dgvStaff.FirstDisplayedScrollingRowIndex = firstVisibleRowIndex;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                }
            }
            Console.WriteLine(this.Text+": Page Refreshed");
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit(loginstaff, "Add",this);
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
            else if(Convert.ToInt32(dgvStaff.CurrentRow.Cells["staff_accesslevel"].Value) >= loginstaff.staff_accesslevel && Convert.ToInt32(dgvStaff.CurrentRow.Cells["staff_id"].Value) != loginstaff.staff_id) 
            {
                MessageBox.Show("アカウントが編集できません", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_S_StaffEdit frmSStaffEdit = new Frm_S_StaffEdit(loginstaff, selected_id, this);
                frmSStaffEdit.ShowDialog();
                closeparent = frmSStaffEdit.closeparent;
                if (closeparent)
                {
                    this.Close();
                }
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
                int selectedlevel = Convert.ToInt32(dgvStaff.CurrentRow.Cells["staff_accesslevel"].Value);
                if (selectedlevel >= loginstaff.staff_accesslevel) 
                {
                    MessageBox.Show("アカウントが削除できません", "エラー",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    DialogResult dret = MessageBox.Show("スタッフを削除しますか", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dret == DialogResult.Yes)
                    {
                        StaffTable staffTable = new StaffTable();
                        int cnt = staffTable.Delete(int.Parse(selected_id));
                        if (cnt > 0) 
                        {
                            SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(),"スタッフ", selected_id.ToString(),"削除","");
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

        private void dgvStaff_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggingDGV = true;
                lastMouseY = e.Y;
            }
        }

        private void dgvStaff_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDraggingDGV)
            {
                DataGridView dgv = sender as DataGridView;
                if (dgv == null || dgv.RowCount == 0) return;

                int deltaY = e.Y - lastMouseY;
                int rowsToScroll = deltaY / SCROLL_SENSITIVITY;

                if (rowsToScroll != 0)
                {
                    try
                    {
                        int currentFirstRow = dgv.FirstDisplayedScrollingRowIndex;
                        int newFirstRow = currentFirstRow - rowsToScroll;
                        newFirstRow = Math.Max(0, newFirstRow);
                        if (newFirstRow != currentFirstRow)
                        {
                            dgv.FirstDisplayedScrollingRowIndex = newFirstRow;
                        }
                        lastMouseY += (rowsToScroll * SCROLL_SENSITIVITY);
                    }
                    catch (ArgumentOutOfRangeException)
                    {
                        Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                    }
                }
            }
        }

        private void dgvStaff_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
        }
    }
}
