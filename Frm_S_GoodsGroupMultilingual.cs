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
    public partial class Frm_S_GoodsGroupMultilingual : Form
    {
        String code;
        int languageno;
        String languagename;
        public Frm_S_GoodsGroupMultilingual(String code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void Frm_S_GoodsGroupMultilingual_Load(object sender, EventArgs e)
        {
            LanguageTable languageTable = new LanguageTable();
            List<Language> languagelist = languageTable.GetAllLanguage();
            foreach (Language language in languagelist) 
            {
                cmbLanguage.Items.Add(language.language_no.ToString()+":"+language.language_name);
            }
            cmbLanguage.SelectedIndex = 0;

        }

        private void cmbLanguage_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLanguage.SelectedIndex > -1) 
            {
                String[] sp = cmbLanguage.Text.Split(':');
                languageno = int.Parse(sp[0]);
                languagename = sp[1];
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                GoodsGroup goodsGroup = goodsGroupTable.GetGroupByCode(languageno, code);
                lblGroupCode.Text = goodsGroup.group_code;
                txbGroupName.Text = goodsGroup.group_name;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult dret = MessageBox.Show("分類コード：" + lblGroupCode.Text + "\n" + "内容言語名：" + languagename + "\n" + "分類名：" + txbGroupName.Text + "\n" + "\n以上の内容に変更しますか", "確認",
                                                       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dret == DialogResult.Yes)
            {
                GoodsGroupTable goodsGroupTable = new GoodsGroupTable();
                GoodsGroup goodsgroup = new GoodsGroup();
                goodsgroup.group_code = lblGroupCode.Text;
                goodsgroup.group_name = txbGroupName.Text;
                goodsgroup.language_no = languageno;
                
                int cnt = goodsGroupTable.UpdateGroupName(goodsgroup);
                MessageBox.Show(cnt + "件の分類情報を変更しました", "変更完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
