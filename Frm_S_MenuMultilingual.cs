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
    public partial class Frm_S_MenuMultilingual : Form
    {
        Form parent;
        string type;
        int id;
        int languageno;
        string languagename;
        //bool anychanged;
        string beforename = "";
        string beforedetail = "";
        public Frm_S_MenuMultilingual(string type, int id, Form parent)
        {
            InitializeComponent();
            lblTitle.Text = "商品" + id.ToString();
            this.type = type;
            this.id = id;
            this.parent = parent;
            if(type == "Add") 
            {
                btnBack.Visible = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dret = MessageBox.Show("商品ID：" + id + "\n" + "内容言語名：" + languagename + "\n" + "商品名：" + txbGoodsName.Text + "\n" + "商品詳細：" + txbGoodsDetail.Text + "\n" + "\n以上の内容に変更しますか", "確認",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dret == DialogResult.Yes) 
            {
                beforename = txbGoodsName.Text;
                beforedetail = txbGoodsDetail.Text;
                GoodsTable goodsTable = new GoodsTable();
                Goods goods = new Goods();
                goods.goods_id = id;
                goods.goods_name = txbGoodsName.Text;
                goods.goods_detail = txbGoodsDetail.Text;
                goods.language_no = languageno;

                int cnt = goodsTable.UpdateGoodsLocalization(goods);
                MessageBox.Show(cnt + "件の商品情報を変更しました", "変更完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);

                beforename = txbGoodsName.Text;
                beforedetail = txbGoodsDetail.Text;
            }
            

        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            if ((beforename != txbGoodsName.Text) || (beforedetail != txbGoodsDetail.Text)) 
            {
                DialogResult dret = MessageBox.Show("未保存の変更があります\n閉じてもよろしいですか", "確認",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dret == DialogResult.Yes)
                {
                    //Frm_S_MenuEditも一緒に閉じる
                    parent.Close();
                    this.Close();
                }
            }
            else 
            {
                //Frm_S_MenuEditも一緒に閉じる
                parent.Close();
                this.Close();
            }
            
            
        }

        private void Frm_S_MenuMultilingual_Load(object sender, EventArgs e)
        {
            LanguageTable languageTable = new LanguageTable();
            List<Language> languagelist = languageTable.GetAllLanguage();
            foreach (Language language in languagelist)
            {
                cmbLanguage.Items.Add(language.language_no.ToString() + ":" + language.language_name);
            }
            cmbLanguage.SelectedIndex = 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex > -1)
            {
                string[] sp = cmbLanguage.Text.Split(':');
                languageno = int.Parse(sp[0]);
                languagename = sp[1];
                GoodsTable goodsTable = new GoodsTable();
                Goods goods = goodsTable.GetGoodsById(languageno, id);
                beforename = goods.goods_name;
                beforedetail = goods.goods_detail;
                txbGoodsName.Text = beforename;
                txbGoodsDetail.Text = beforedetail;
            }
        }
    }
}
