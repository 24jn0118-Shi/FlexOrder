using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class MealTicket : UserControl
    {

        public MealTicket()
        {
            InitializeComponent();
        }
        public void Bind(Order order, OrderDetail detail)
        {
            lblGoodsNameA.Text = detail.goods_name;
            lblGoodsNameB.Text = lblGoodsNameA.Text;

            lblPriceA.Text = detail.price.ToString("N0");
            lblPriceB.Text = lblPriceA.Text;

            lblIsTakeout.Text = order.is_takeout ? "持帰" : "店内";

            lblDate.Text = order.order_date.ToString("yyyy/MM/dd");
            lblTimeA.Text = order.order_date.ToString("HH:mm");
            lblTimeB.Text = lblTimeA.Text;

            string todayid = order.order_id.ToString();
            while (todayid.Length < 3)
            {
                todayid = "0" + todayid;
            }
            lblNoA.Text = todayid;
            lblNoB.Text = lblNoA.Text;
        }
    }
}

    
