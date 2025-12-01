using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class Order
    {
        public int order_id { get; set; }
        public DateTime order_date { get; set; }
        public int order_seat { get; set; }
        public bool is_takeout { get; set; }
        public List<OrderDetail> orderdetaillist { get; set; } = new List<OrderDetail>();
        public int TotalPrice
        {
            get
            {
                return orderdetaillist.Sum(item => item.Subtotal);
            }
        }
        public void AddOrUpdateItem(int newgoods_id, string newgoods_name, int newprice, int newquantity) // 修正 price 为 int
        {
            var existingItem = orderdetaillist.FirstOrDefault(i => i.goods_id == newgoods_id);

            if (existingItem != null)
            {
                existingItem.quantity = newquantity;
            }
            else
            {
                orderdetaillist.Add(new OrderDetail
                {
                    goods_id = newgoods_id,
                    goods_name = newgoods_name,
                    price = newprice,
                    quantity = newquantity
                });
            }
        }

    }
}
