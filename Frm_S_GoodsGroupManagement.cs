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
            dgvGroupList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvGroupList.MultiSelect = false;
            dgvGroupList.AutoGenerateColumns = false;
            refresh_page();
        }
        private void refresh_page()
        {
            //selected_id = null;
            txbSortCode.Text = "";
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            DataTable dataTable = goodsGroupTable.GetAllGroup();
            dgvGroupList.DataSource = dataTable;
            dgvGroupList.ClearSelection();
            Console.WriteLine("Page Refreshed");
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
                refresh_page();
            }
        }
    }
}
