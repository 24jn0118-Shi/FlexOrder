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
        int id;
        bool replaceimg = false;
        bool anychanged = false;
        byte[] oldimageBytes = null;
        byte[] newimageBytes = null;
        Goods editgoods = null;
        Image oldimage;
        Staff loginstaff = null;
        public Frm_S_MenuEdit(string type, Staff loginstaff)
        {
            InitializeComponent();
            this.type = type;
            if (type == "Add")
            {
                lblTitle.Text = "商品追加";
            }
            else
            {
                lblTitle.Text = "商品編集";
                bool res = int.TryParse(type, out id);
            }
            this.loginstaff = loginstaff;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            GoodsTable goodsTable = new GoodsTable();
            Goods goods = null;
            string errs = "";
            bool parseresult = int.TryParse(txtPrice.Text, out int newprice);
            if (type == "Add")
            {
                if (cmbGroup.SelectedIndex < 0) 
                {
                    errs += "分類を選択してください\n";
                }
                if (txtPrice.Text == "")
                {
                    errs += "価格を入力してください\n";
                }
                else if (!parseresult)
                {
                    errs += "価格は整数を入力してください\n";
                }
                else if (newprice < 0)
                {
                    errs += "価格は0以上で入力してください\n";
                }
                if (errs != "") 
                {
                    MessageBox.Show(errs, "エラー",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else 
                {
                    string replace = replaceimg ? "あり" : "なし";
                    DialogResult dret = MessageBox.Show("商品分類：" + cmbGroup.Text + " " + lblGroupName.Text + "\n" +"商品単価(¥)：" + newprice + "\n" + "おすすめ：" + cboxRecommend.Checked + "\n" + "ベジタリアン：" + cboxVege.Checked + "\n" + "商品在庫：" + cboxAvailable.Checked + "\n" + "商品画像：" + replace + "\n" + "\n以上の内容で登録してよろしいですか", "確認", 
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dret == DialogResult.Yes)
                    {
                        goods = new Goods();
                        goods.group_code = cmbGroup.Text;
                        goods.goods_price = newprice;
                        goods.is_recommend = cboxRecommend.Checked;
                        goods.is_vegetarian = cboxVege.Checked;
                        goods.is_available = cboxAvailable.Checked;
                        goods.goods_image_bytes = newimageBytes;
                        int newid = goodsTable.InsertNewGoods(goods);
                        if (newid > 0) 
                        {
                            if (replaceimg) 
                            {
                                Task.Run(() => ImagePro.CheckAndCacheAllImages(true));
                            }
                            SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(), "商品", newid.ToString(), "登録", "Group: "+ goods.group_code);
                            MessageBox.Show("商品情報を登録しました", "登録完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Frm_S_MenuMultilingual frm_S_MenuMultilingual = new Frm_S_MenuMultilingual(type, newid, this);
                            frm_S_MenuMultilingual.ShowDialog();
                            this.Close();
                        }
                        else 
                        {
                            MessageBox.Show("登録失敗", "エラー",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                if (txtPrice.Text == "")
                {
                    errs += "価格を入力してください\n";
                }
                else if (!parseresult)
                {
                    errs += "価格は整数を入力してください\n";
                }
                else if (newprice < 0)
                {
                    errs += "価格は0以上で入力してください\n";
                }
                if (errs != "")
                {
                    MessageBox.Show(errs, "エラー",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    goods = new Goods();
                    goods.goods_id = id;
                    goods.group_code = cmbGroup.Text;
                    goods.goods_price = newprice;
                    goods.is_recommend = cboxRecommend.Checked;
                    goods.is_vegetarian = cboxVege.Checked;
                    goods.is_available = cboxAvailable.Checked;
                    if (replaceimg)
                    {
                        goods.goods_image_bytes = newimageBytes;
                    }
                    else
                    {
                        goods.goods_image_bytes = oldimageBytes;
                    }
                    string replace = replaceimg ? "あり" : "なし";
                    if ((editgoods.group_code != cmbGroup.Text) || (editgoods.is_available != goods.is_available) || (editgoods.is_vegetarian != goods.is_vegetarian) || (editgoods.is_recommend != goods.is_recommend) || (editgoods.goods_price != goods.goods_price) || replaceimg)
                    {
                        anychanged = true;
                    }
                    if (anychanged)
                    {
                        DialogResult dret = MessageBox.Show("商品ID：" + txtId.Text + "\n" + "商品分類：" + cmbGroup.Text + " " + lblGroupName.Text + "\n" + "商品単価(¥)：" + newprice + "\n" + "おすすめ：" + cboxRecommend.Checked + "\n" + "ベジタリアン：" + cboxVege.Checked + "\n" + "商品在庫：" + cboxAvailable.Checked + "\n" + "商品画像：" + replace + "\n" + "\n以上の内容で登録してよろしいですか", "確認",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (dret == DialogResult.Yes)
                        {

                            int cnt = goodsTable.Update(goods);
                            if (cnt == 1)
                            {
                                if (replaceimg)
                                {
                                    Task.Run(() => ImagePro.CheckAndCacheAllImages(true));
                                }
                                SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(), "商品", goods.goods_id.ToString(), "変更", "Group: " + goods.group_code);
                                MessageBox.Show("商品情報を変更しました", "変更完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                                Frm_S_MenuMultilingual frm_S_MenuMultilingual = new Frm_S_MenuMultilingual(type, goods.goods_id, this);
                                frm_S_MenuMultilingual.ShowDialog();
                            }
                            else
                            {
                                MessageBox.Show("変更失敗", "エラー",
                                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                    }
                    else
                    {
                        Frm_S_MenuMultilingual frm_S_MenuMultilingual = new Frm_S_MenuMultilingual(type, goods.goods_id, this);
                        frm_S_MenuMultilingual.ShowDialog();
                    }
                    anychanged = false;
                    editgoods = goodsTable.GetGoodsById(1, id);
                    if (editgoods.goods_image_bytes != null)
                    {
                        oldimageBytes = editgoods.goods_image_bytes;
                        oldimage = ImagePro.ConvertByteArrayToImage(oldimageBytes);
                        picboxImage.Image = oldimage;
                    }
                    newimageBytes = null;
                    replaceimg = false;
                }
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
            List<GoodsGroup> grouplist = goodsGroupTable.GetGroupByLanguage(1);
            foreach (GoodsGroup group in grouplist)
            {
                cmbGroup.Items.Add(group.group_code);

            }
            lblGroupName.Text = "";
            if (type == "Add")
            {
                txtId.Visible = false;
                lblGoodsId.Visible = false;
                cmbGroup.SelectedIndex = -1;
            }
            else
            {
                txtId.Text = id.ToString();
                editgoods = goodsTable.GetGoodsById(1, id);
                GoodsGroup goodsGroup = goodsGroupTable.GetGroupByCode(1, editgoods.group_code);
                lblGroupName.Text = goodsGroup.group_name;
                txtPrice.Text = editgoods.goods_price.ToString();
                cboxRecommend.Checked = editgoods.is_recommend;
                cboxAvailable.Checked = editgoods.is_available;
                cboxVege.Checked = editgoods.is_vegetarian;
                if (editgoods.goods_image_bytes != null) 
                {
                    oldimageBytes = editgoods.goods_image_bytes;
                    oldimage = ImagePro.ConvertByteArrayToImage(oldimageBytes);
                    picboxImage.Image = oldimage;
                }
                cmbGroup.SelectedItem = editgoods.group_code;
            }
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cmbGroup.SelectedIndex > -1)
            {
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                GoodsGroup goodsGroup = goodsGroupTable.GetGroupByCode(1, cmbGroup.Text);
                lblGroupName.Text = goodsGroup.group_name;
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
