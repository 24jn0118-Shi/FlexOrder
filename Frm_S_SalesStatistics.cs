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
    public partial class Frm_S_SalesStatistics : Form
    {
        public Frm_S_SalesStatistics()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_SalesStatistics_Load(object sender, EventArgs e)
        {
            dtpStart.Value = DateTime.Today;
            dtpEnd.Value = DateTime.Today;
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            List<GoodsGroup> grouplist = goodsGroupTable.GetGroupByLanguage(1);
            cmbGroup.Items.Add("分類指定なし");
            foreach (GoodsGroup group in grouplist)
            {
                cmbGroup.Items.Add(group.group_name);
            }
            cmbGroup.SelectedIndex = 0;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Goods> goodslist;
            GoodsTable goodsTable = new GoodsTable();
            if (cmbGroup.SelectedIndex > 0) 
            {
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                
                GoodsGroup selectedGroup = goodsGroupTable.GetGroupBySort(1, cmbGroup.SelectedIndex);
                goodslist = goodsTable.GetGoodsByGroup(1, selectedGroup.group_code, false);
            }
            else 
            {
                goodslist = goodsTable.GetAllGoodsList(1);
            }
            cmbGoods.Items.Clear();
            cmbGoods.Items.Add("商品指定なし");
            foreach (Goods good in goodslist)
            {
                cmbGoods.Items.Add(good.goods_name);
            }
            cmbGoods.SelectedIndex = 0;

        }
    }
}
