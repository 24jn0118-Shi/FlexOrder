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
        }
        public int price
        {
            get { return price; }
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

        public DateTime OrderDate
        {
            get { return OrderDate; }
            set {
                lblDate.Text = value.ToString("yyyy/MM/dd");
                lblTimeA.Text = value.ToString("HH/mm");
                lblTimeB.Text = lblTimeA.Text;
            }
        }
        public int price
        {
            get { return price; }
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

        public DateTime OrderDate
        {
            get { return OrderDate; }
            set {
                lblDate.Text = value.ToString("yyyy/MM/dd");
                lblTimeA.Text = value.ToString("HH/mm");
                lblTimeB.Text = lblTimeA.Text;
            }
        }

        private void MealTicket_Load(object sender, EventArgs e)
        {
            
        }
        
    }
}
