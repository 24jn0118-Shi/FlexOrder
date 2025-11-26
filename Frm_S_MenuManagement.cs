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
    public partial class Frm_S_MenuManagement : Form
    {
        string selected_goodscode = null;
        public Frm_S_MenuManagement(Staff staff)
        {
            InitializeComponent();
            if (!staff.is_manager) 
            {
                btnAddGoods.Visible = false;
                btnAddGroup.Visible = false;
                btnEditGoods.Visible = false;
                btnDeleteGoods.Visible = false;
            }
        }

        private void btnAddGoods_Click(object sender, EventArgs e)
        {
            Frm_S_MenuEdit frm_S_MenuEdit = new Frm_S_MenuEdit("Add");
            frm_S_MenuEdit.ShowDialog();
        }
        private void btnEditGoods_Click(object sender, EventArgs e)
        {
            if(selected_goodscode == null) 
            {
                MessageBox.Show("商品を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Frm_S_MenuEdit frm_S_MenuEdit = new Frm_S_MenuEdit(selected_goodscode);
                frm_S_MenuEdit.ShowDialog();
                Refresh_page();
            }
        }
        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            if (selected_goodscode == null)
            {
                MessageBox.Show("商品を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                //！！！未完成
                DialogResult dret = MessageBox.Show("商品を削除しますか", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {
                    GoodsTable goodsTable = new GoodsTable();
                    Goods goods = goodsTable.GetGoodsByCode(1, selected_goodscode);
                    int cnt = goodsTable.Delete(goods);
                    if (cnt > -999)
                    {
                        MessageBox.Show(cnt + "件の商品を削除しました", "削除完了",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    Refresh_page();
                }
            }
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Frm_S_GoodsGroupManagement frm_S_GoodsGroupManagement = new Frm_S_GoodsGroupManagement();
            frm_S_GoodsGroupManagement.ShowDialog();
        }
        private void btnChangeAvailable_Click(object sender, EventArgs e)
        {

        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_MenuManagement_Load(object sender, EventArgs e)
        {
            dgvMenu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMenu.MultiSelect = false;
            dgvMenu.AutoGenerateColumns = false;
            Refresh_page();
        
        }
        private void Refresh_page()
        {
            selected_goodscode = null;
            GoodsTable goodsTable = new GoodsTable();
            DataTable table = goodsTable.GetAllGoods();
            table.Columns.Add("str_is_recommend", typeof(string));
            table.Columns.Add("str_is_available", typeof(string));
            table.Columns.Add("index", typeof(int));
            int index = 1;
            foreach (DataRow row in table.Rows)
            {
                row["index"] = index;
                index++;
                bool flag = Convert.ToBoolean(row["is_recommend"]);
                row["str_is_recommend"] = flag ? "〇" : "";
                flag = Convert.ToBoolean(row["is_available"]);
                row["str_is_available"] = flag ? "〇" : "";
            }
            dgvMenu.DataSource = table;
            
            dgvMenu.ClearSelection();
            Console.WriteLine(this.Text + ": Page Refreshed");
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_goodscode = dgvMenu.CurrentRow.Cells["goods_code"].Value.ToString();
        }
    }
}
