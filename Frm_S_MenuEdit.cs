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
        bool replaceimg = false;
        bool anychanged = false;
        byte[] oldimageBytes = null;
        byte[] newimageBytes = null;
        Goods editgoods = null;
        Image oldimage;
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
            string errs = "";
            if (type == "Add")
            {
                //INSERT
                bool parseresult = int.TryParse(lblPrice.Text, out int newprice);
                if (cmbGroup.SelectedIndex < 0) 
                {
                    errs += "分類を選択してください\n";
                    
                }
                if (lblPrice.Text == "")
                {
                    errs += "価格を入力してください\n";
                }
                else if (!parseresult)
                {
                    errs += "価格は整数を入力してください\n";
                }
                if(picboxImage.Image == null) 
                {
                    Console.WriteLine("Imageなし");
                }
                else 
                {
                    Console.WriteLine("Imageあり");
                }
                if (errs != "") 
                {
                    MessageBox.Show(errs, "エラー",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    DialogResult dret = MessageBox.Show("以上の内容で登録してよろしいですか", "確認", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dret == DialogResult.Yes)
                    {
                        //Frm_S_MenuMultilingual frm_S_MenuMultilingual = new Frm_S_MenuMultilingual(type, this);
                        //frm_S_MenuMultilingual.ShowDialog();
                    }
                }
                    
            }
            else
            {
                //UPDATE






                //If Updated --> ImagePro.CheckAndCacheAllImages(true);
                //Frm_S_MenuMultilingual frm_S_MenuMultilingual = new Frm_S_MenuMultilingual(type, this);
                //frm_S_MenuMultilingual.ShowDialog();
            }





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
                editgoods = goodsTable.GetGoodsByCode(1, type);
                GoodsGroup goodsGroup = goodsGroupTable.GetGroupByCode(1, editgoods.group_code);
                lblGroupName.Text = goodsGroup.group_name;
                txtPrice.Text = editgoods.goods_price.ToString();
                cboxRecommend.Checked = editgoods.is_recommend;
                cboxAvailable.Checked = editgoods.is_available;
                cboxVege.Checked = editgoods.is_vegetarian;
                string imagePath = ImagePro.GetImagePath(editgoods.goods_image_filename);
                if (File.Exists(imagePath))
                {
                    using (var tempImage = Image.FromFile(imagePath))
                    {
                        oldimage = new Bitmap(tempImage);
                        picboxImage.Image = oldimage;
                    }
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
            string newfileName;
            DialogResult ret = ofdImage.ShowDialog();
            if (ret == DialogResult.OK)
            {
                newfileName = ofdImage.FileName;

                newimageBytes = File.ReadAllBytes(newfileName);
                Console.WriteLine("Loaded Bytes From " + newfileName);
                picboxImage.Image = ImagePro.ConvertByteArrayToImage(newimageBytes);
                if (newimageBytes != null) 
                {
                    replaceimg = true;
                }
                
            }
        }

        private void Frm_S_MenuEdit_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnClearImage_Click(object sender, EventArgs e)
        {
            newimageBytes = null;
            replaceimg = false;
            if (type == "Add")
            {
                picboxImage.Image = null;
            }
            else
            {
                picboxImage.Image = oldimage;
            }
        }
    }
}
