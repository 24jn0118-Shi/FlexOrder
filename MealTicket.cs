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
        public MealTicket()
        {
            InitializeComponent();
        }
        public int Price
        {
            get { return Price; }
            set { lblPriceA.Text = value.ToString();
                lblPriceB.Text = value.ToString();
            }
        }

        public bool Is_takeout
        {
            get { return Is_takeout; }
            set {
                if (value == false)
                {
                    lblIsTakeout.Text = "店内";
                }
                else
                {
                    lblIsTakeout.Text = "持帰";
                }
            }
        }

        public string Goods_name
        {
            get { return Goods_name; }
            set { lblGoodsNameA.Text = value.ToString();
                lblGoodsNameB.Text = value.ToString();
            }
        }

        public DateTime Order_date
        {
            get { return Order_date; }
            set {
                lblDate.Text = value.ToString("yyyy/MM/dd");
                lblTimeA.Text = value.ToString("HH/mm");
                lblTimeB.Text = lblTimeA.Text;
            }
        }
        
    }
}
