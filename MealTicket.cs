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
    public partial class MealTicket : UserControl
    {
        public MealTicket(Order order, OrderDetail detail)
        {
            InitializeComponent();
            // 注文データを各ラベルに反映
            lblDate.Text = DateTime.Now.ToString("yyyy/MM/dd");
            lblTimeA.Text = DateTime.Now.ToString("HH/mm");
            lblTimeB.Text = lblTimeA.Text;
            lblGoodsNameA.Text = detail.goods_name;
            lblGoodsNameB.Text = lblGoodsNameA.Text;
            if (order.is_takeout==false)
            {
                lblIsTakeout.Text = "店内";
            }
            else
            {
                lblIsTakeout.Text = "持帰";
            }
            lblPriceA.Text = detail.price.ToString();
            lblPriceB.Text = lblPriceA.Text;
            
        }

        private void MealTicket_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
