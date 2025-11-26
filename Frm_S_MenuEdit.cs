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
    public partial class Frm_S_MenuEdit : Form
    {
        string type;
        string nextno;
        public Frm_S_MenuEdit(String type)
        {
            InitializeComponent();
            if (type == "Add")
            {
                lblTitle.Text = "商品追加";
            } else
            {
                lblTitle.Text = "商品編集";
            }
            this.type = type;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Frm_S_MenuMultilingual frm_S_MenuMultilingual = new Frm_S_MenuMultilingual(type, this);
            frm_S_MenuMultilingual.ShowDialog();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_S_MenuEdit_Load(object sender, EventArgs e)
        {
            GoodsTable goodsTable = new GoodsTable();
            nextno = (int.Parse(goodsTable.GetLastGoodsNo()) + 1).ToString();
            while (nextno.Length < 4) 
            {
                nextno = "0" + nextno;
            }
            txtCode.Text = nextno;
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            List<GoodsGroup> grouplist = goodsGroupTable.GetGroupByLanguage(1);
            foreach (GoodsGroup group in grouplist) 
            {
                cmbGroup.Items.Add(group.group_code);
                
            }
            cmbGroup.SelectedIndex = -1;
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbGroup.SelectedIndex > -1) 
            {
                GoodsGroupTable goodsGroupTable1 = new GoodsGroupTable();
                GoodsGroup goodsGroup = goodsGroupTable1.GetGroupByCode(1, cmbGroup.Text);
                lblGroupName.Text = goodsGroup.group_name;
                txtCode.Text = cmbGroup.Text + nextno;
            }
        }
    }
}
