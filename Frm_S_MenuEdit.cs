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
    public partial class Frm_S_MenuEdit : Form
    {
        string type;
        string nextno;
        string oldimg;
        bool replaceimg = false;
        public Frm_S_MenuEdit(String type)
        {
            InitializeComponent();
            if (type == "Add")
            {
                lblTitle.Text = "商品追加";
            }
            else
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
            GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
            GoodsTable goodsTable = new GoodsTable();
            lblGroupName.Text = "";
            if (type == "Add")
            {

                nextno = (int.Parse(goodsTable.GetLastGoodsNo()) + 1).ToString();
                while (nextno.Length < 4)
                {
                    nextno = "0" + nextno;
                }
                txtCode.Text = nextno;

                List<GoodsGroup> grouplist = goodsGroupTable.GetGroupByLanguage(1);
                foreach (GoodsGroup group in grouplist)
                {
                    cmbGroup.Items.Add(group.group_code);

                }
                cmbGroup.SelectedIndex = -1;
            }
            else
            {
                lblGroup.Visible = false;
                cmbGroup.Visible = false;
                txtCode.Text = type;
                Goods goods = goodsTable.GetGoodsByCode(1, type);
                GoodsGroup goodsGroup = goodsGroupTable.GetGroupByCode(1, goods.group_code);
                lblGroupName.Text = goodsGroup.group_name;
                txtPrice.Text = goods.goods_price.ToString();
                cboxRecommend.Checked = goods.is_recommend;
                cboxAvailable.Checked = goods.is_available;
                cboxVege.Checked = goods.is_vegetarian;

                ImagePro imagePro = new ImagePro();
                oldimg = goods.goods_image;
                String oldimagepath = imagePro.GetImagePath(oldimg);
                if (picboxImage.Image != null)
                {
                    picboxImage.Image.Dispose();
                    picboxImage.Image = null;
                }
                using (FileStream fs = new FileStream(oldimagepath, FileMode.Open, FileAccess.Read))
                {
                    Image img = Image.FromStream(fs);
                    picboxImage.Image = img;
                }

            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGroup.SelectedIndex > -1)
            {
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                GoodsGroup goodsGroup = goodsGroupTable.GetGroupByCode(1, cmbGroup.Text);
                lblGroupName.Text = goodsGroup.group_name;
                txtCode.Text = cmbGroup.Text + nextno;
            }
        }

        private void btnSelectImageFile_Click(object sender, EventArgs e)
        {
            string fileName;
            DialogResult ret = ofdImage.ShowDialog();
            if (ret == DialogResult.OK)
            {
                fileName = ofdImage.FileName;

            }
        }

    }
}
