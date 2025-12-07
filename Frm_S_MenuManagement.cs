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
    public partial class Frm_S_MenuManagement : Form
    {
        int selected_goodsid = -1;
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
            Refresh_page();
        }
        private void btnEditGoods_Click(object sender, EventArgs e)
        {
            if(selected_goodsid < 0) 
            {
                MessageBox.Show("商品を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                Frm_S_MenuEdit frm_S_MenuEdit = new Frm_S_MenuEdit(selected_goodsid.ToString());
                frm_S_MenuEdit.ShowDialog();
                Refresh_page();
            }
        }
        private void btnDeleteGoods_Click(object sender, EventArgs e)
        {
            if (selected_goodsid < 0)
            {
                MessageBox.Show("商品を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DialogResult dret = MessageBox.Show("商品を削除しますか", "確認",
                                                           MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes)
                {
                    GoodsTable goodsTable = new GoodsTable();
                    int cnt = goodsTable.Delete(selected_goodsid);
                    if (cnt > 0)
                    {
                        MessageBox.Show(cnt + "件の商品を削除しました", "削除完了",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } else 
                    {
                        MessageBox.Show("削除失敗", "削除失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                        Refresh_page();
                }
            }
        }
        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Frm_S_GoodsGroupManagement frm_S_GoodsGroupManagement = new Frm_S_GoodsGroupManagement();
            frm_S_GoodsGroupManagement.ShowDialog();
            Refresh_page();
        }
        private void btnChangeAvailable_Click(object sender, EventArgs e)
        {
            if (selected_goodsid < 0)
            {
                MessageBox.Show("商品を選択してください", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string target = "";
                if (dgvMenu.CurrentRow.Cells["str_is_available"].Value.ToString() == "〇") 
                {
                    target = "在庫なし";
                } else 
                {
                    target = "在庫あり";
                }
                    DialogResult dret = MessageBox.Show("商品を " + target + " に変更しますか", "確認",
                                                               MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dret == DialogResult.Yes) 
                {
                    GoodsTable goodsTable = new GoodsTable();
                    Goods goods = goodsTable.GetGoodsById(1, selected_goodsid);
                    int cnt = goodsTable.UpdateAvailable(goods);
                    if (cnt > 0)
                    {
                        MessageBox.Show(cnt + "件の商品の在庫状況を変更しました", "変更完了",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("変更失敗", "変更失敗",
                                                       MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    Refresh_page();
                }
            }

            
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_MenuManagement_Load(object sender, EventArgs e)
        {
            dgvMenu.AutoGenerateColumns = false;
            Refresh_page();
        }
        private void Refresh_page()
        {
            selected_goodsid = -1;
            GoodsTable goodsTable = new GoodsTable();
            DataTable table = goodsTable.GetAllGoods();
            table.Columns.Add("str_is_recommend", typeof(string));
            table.Columns.Add("str_is_available", typeof(string));
            table.Columns.Add("index", typeof(int));
            foreach (DataRow row in table.Rows)
            {
                bool flag = Convert.ToBoolean(row["is_recommend"]);
                row["str_is_recommend"] = flag ? "〇" : "";
                flag = Convert.ToBoolean(row["is_available"]);
                row["str_is_available"] = flag ? "〇" : "✕";
            }
            dgvMenu.DataSource = table;
            
            dgvMenu.ClearSelection();
            Console.WriteLine(this.Text + ": Page Refreshed");
        }

        private void dgvMenu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selected_goodsid = (int)dgvMenu.CurrentRow.Cells["goods_id"].Value;
        }
    }
}
