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
        int thisid;
        int thisprice;
        int num = 1;
        public OrderDetail AddedItem { get; private set; }
        public Frm_C_GoodsDetail(int id)
        {
            InitializeComponent();
            thisid = id;
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
            Goods goods = goodsTable.GetGoodsById(currentLangNo, thisid);
            lblGoodsName.Text = goods.goods_name;
            lblDetail.Text = goods.goods_detail;
            thisprice = goods.goods_price;
            lblPrice.Text = "¥ " + goods.goods_price.ToString("N0");
            lblNum.Text = num.ToString();
            string imagePath = ImagePro.GetImagePath(goods.goods_image_filename);
            if (File.Exists(imagePath))
            {
                using (var tempImage = Image.FromFile(imagePath))
                {
                    picGoods.Image = new Bitmap(tempImage);
                }
            }
            else
            {
                picGoods.Image = Properties.Resources.noimage;
            }
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(num > 1) 
            {
                lblNum.Text = (num - 1).ToString();
            }
            num = int.Parse(lblNum.Text);
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(num < 10) 
            { 
                lblNum.Text = (num + 1).ToString();
            }
            num = int.Parse(lblNum.Text);
        }
        private void btnAddtoCart_Click(object sender, EventArgs e)
        {
            this.AddedItem = new OrderDetail
            {
                goods_id = thisid,
                goods_name = lblGoodsName.Text,
                price = thisprice,
                quantity = num
            };
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
