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
                int languageno = int.Parse(sp[0]);
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
    }
}
