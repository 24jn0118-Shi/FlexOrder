using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
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
        string code;
        int num = 1;
        public Frm_C_GoodsDetail(string code)
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
            Goods goods = goodsTable.GetGoodsByCode(currentLangNo, code);
            lblGoodsName.Text = goods.goods_name;
            lblDetail.Text = goods.goods_detail;
            lblPrice.Text = "¥ " + goods.goods_price.ToString("N0");
            lblNum.Text = "1";
            ImagePro imagePro = new ImagePro();
            String image = imagePro.GetImagePath(goods.goods_image);
            using (FileStream fs = new FileStream(image, FileMode.Open, FileAccess.Read))
            {
                Image img = Image.FromStream(fs);
                picGoods.Image = img;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            num = int.Parse(lblNum.Text);
            if(num > 1) 
            {
                lblNum.Text = (num - 1).ToString();
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            num = int.Parse(lblNum.Text);
            lblNum.Text = (num + 1).ToString();
        }
    }
}
