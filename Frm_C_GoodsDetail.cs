using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_GoodsDetail : Form
    {
        private readonly Dictionary<string, int> langMap = new Dictionary<string, int>()
        {
            { "ja", 1 }, { "en", 2 }, { "zh", 3 }, { "ru", 4 }
        };

        private int thisid;
        private int thisprice;
        private int num = 1;

        public OrderDetail AddedItem { get; private set; }

        public Frm_C_GoodsDetail(int id)
        {
   
            this.FormBorderStyle = FormBorderStyle.None;
            InitializeComponent();

            this.thisid = id;

            this.Paint += Frm_C_Detail_Border;

            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.AllPaintingInWmPaint, true);
        }

        private void Frm_C_GoodsDetail_Load(object sender, EventArgs e)
        {
            string currentLang = Thread.CurrentThread.CurrentUICulture.Name;
            int currentLangNo = 1;
            if (langMap.TryGetValue(currentLang, out int result)) currentLangNo = result;

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

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (num > 1) num--;
            lblNum.Text = num.ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (num < 10) num++;
            lblNum.Text = num.ToString();
        }

        private void Frm_C_Detail_Border(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.Black, 1))
            {
                e.Graphics.DrawRectangle(pen, 0, 0, this.Width - 1, this.Height - 1);
            }
        }

        private void btnAddtoCart_Click_1(object sender, EventArgs e)
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

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}