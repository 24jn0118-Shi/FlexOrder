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
    public partial class Frm_S_GoodsGroupManagement : Form
    {
        private bool isDraggingDGV = false;
        private int lastMouseY = 0;
        private const int SCROLL_SENSITIVITY = 15;
        public Frm_S_GoodsGroupManagement()
        {
            InitializeComponent();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_S_GoodsGroupManagement_Load(object sender, EventArgs e)
        {
            dgvGroupList.AutoGenerateColumns = false;
            Refresh_page();
        }
        private void Refresh_page()
        {
            int firstVisibleRowIndex = -1;
            if (dgvGroupList.Rows.Count > 0 && dgvGroupList.FirstDisplayedScrollingRowIndex >= 0)
            {
                firstVisibleRowIndex = dgvGroupList.FirstDisplayedScrollingRowIndex;
            }
            txbSortCode.Text = "";
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            DataTable dataTable = goodsGroupTable.GetAllGroup();
            dgvGroupList.DataSource = dataTable;
            dgvGroupList.ClearSelection();
            Console.WriteLine(this.Text+": Page Refreshed");
            if (firstVisibleRowIndex >= 0 && firstVisibleRowIndex < dgvGroupList.Rows.Count)
            {
                try
                {
                    dgvGroupList.FirstDisplayedScrollingRowIndex = firstVisibleRowIndex;
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("FirstDisplayedScrollingRowIndex Error");
                }
            }
        }
        private void dgvGroupList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txbSortCode.Text = dgvGroupList.CurrentRow.Cells["group_code"].Value.ToString();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txbSortCode.Text == "")
            {
                MessageBox.Show("分類を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Frm_S_GoodsGroupMultilingual frm_S_GoodsGroupMultilingual = new Frm_S_GoodsGroupMultilingual(txbSortCode.Text);
                frm_S_GoodsGroupMultilingual.ShowDialog();
                Refresh_page();
            }
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txbGroupCode.Text) || string.IsNullOrEmpty(txbGroupName.Text)) 
            {
                MessageBox.Show("分類情報を入力してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (!txbGroupCode.Text.All(char.IsUpper) || txbGroupCode.Text.Length != 2) 
            {
                MessageBox.Show("分類情報は大文字アルファベット2文字で入力してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                GoodsGroup group = goodsGroupTable.GetGroupByCode(1, txbGroupCode.Text);
                if (group != null) 
                {
                    MessageBox.Show("分類コードは既に存在します", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dret = MessageBox.Show("分類コード：" + txbGroupCode.Text + "\n" + "分類名（日本語）：" + txbGroupName.Text + "\n" + "\n以上の内容で登録しますか？", "確認",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dret == DialogResult.Yes)
                    {

                        GoodsGroup newgroup = new GoodsGroup();
                        newgroup.group_code = txbGroupCode.Text;
                        newgroup.group_name = txbGroupName.Text;
                        newgroup.language_no = 1;
                        int cnt = goodsGroupTable.InsertNewGroup(newgroup);
                        if(cnt == 4) 
                        {
                            MessageBox.Show("分類を登録しました", "登録完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        Refresh_page();
                    }
                }
            }
        }
        private void btnGoSort_Click(object sender, EventArgs e)
        {
            if (txbSortCode.Text == "")
            {
                MessageBox.Show("分類を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(txbSortIndex.Text == "")
            {
                MessageBox.Show("目標順番を入力してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(!int.TryParse(txbSortIndex.Text, out int target))
            {
                MessageBox.Show("目標順番は整数を入力してください", "エラー",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                int maxsort = goodsGroupTable.GetMaxSort();
                GoodsGroup goodsGroup = goodsGroupTable.GetGroupByCode(1, txbSortCode.Text);
                if (target > maxsort || target <= 0 || target == goodsGroup.group_sort) 
                {
                    MessageBox.Show("目標順番は無効です", "エラー",
                                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    DialogResult dret = MessageBox.Show("並び替える分類コード：：" + txbSortCode.Text + "\n" + "目標順番：" + txbSortIndex.Text + "\n" + "\n以上の内容で並び替えますか？", "確認",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dret == DialogResult.Yes) 
                    {
                        int cnt = goodsGroupTable.SortGroup(goodsGroup, target);
                        if (cnt == 1)
                        {
                            MessageBox.Show("並び替えました", "整列完了",
                                                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txbSortIndex.Text = "";
                            Refresh_page();
                        }
                    }
                }
            }
            

        }

        private void dgvGroupList_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDraggingDGV = true;
                lastMouseY = e.Y;
            }
        }

        private void dgvGroupList_MouseMove(object sender, MouseEventArgs e)
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

        private void dgvGroupList_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingDGV = false;
        }
    }
}
