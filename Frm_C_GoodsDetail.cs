using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_GoodsDetail : Form
    {
        Dictionary<string, int> langMap = new Dictionary<string, int>()
        {
            { "ja", 1 },
            { "en", 2 },
            { "zh", 3 },
            { "ru", 4 }
        };
        String code;
        public Frm_C_GoodsDetail(String code)
        {
            InitializeComponent();
            this.code = code;
        }

        private void Frm_C_GoodsDetail_Load(object sender, EventArgs e)
        {
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;
            int currentLangNo = 1;
            if (langMap.TryGetValue(currentLang, out int result))
            {
                currentLangNo = result;
            }
            GoodsTable goodsTable = new GoodsTable();
            Goods goods = goodsTable.GetGoodsByCode(code, currentLangNo);
            lblGoodsName.Text = goods.goods_name;
            lblDetail.Text = goods.goods_detail;
            lblPrice.Text = "¥ " + goods.goods_price.ToString("N0");
            lblNum.Text = "1";
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
