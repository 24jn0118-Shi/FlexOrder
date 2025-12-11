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
        public int? order_seat { get; set; }
        public bool is_takeout { get; set; }
        public List<OrderDetail> orderdetaillist { get; set; } = new List<OrderDetail>();
        public int TotalPrice
        {
            get
            {
                return orderdetaillist.Sum(item => item.Subtotal);
            }
        }
        public void AddItem(int newgoods_id, string newgoods_name, int newprice, int newquantity)
        {
            var existingItem = orderdetaillist.FirstOrDefault(i => i.goods_id == newgoods_id);
            if (existingItem != null)
            {
                existingItem.quantity += newquantity;
                if (existingItem.quantity > 10) 
                {
                    existingItem.quantity = 10;
                }
            }
            else
            {
                if (newquantity > 0 && newquantity <= 10) 
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
        public void PlusMinus(int editgoods_id, int ordertype) 
        {
            var existingItem = orderdetaillist.FirstOrDefault(i => i.goods_id == editgoods_id);
            if (existingItem != null)
            {
                switch (ordertype)
                { 
                    case -1:
                        if (existingItem.quantity > 1) 
                        {
                            existingItem.quantity -= 1;
                        }
                        else 
                        {
                            //orderdetaillist.Remove(existingItem);
                        }
                        break;
                    case 0:
                        orderdetaillist.Remove(existingItem);
                        break;
                    case 1:
                        if (existingItem.quantity <10)
                        {
                            existingItem.quantity += 1;
                        }
                        else 
                        {
                            existingItem.quantity = 10;
                        }
                        break;
                    default:
                        Console.WriteLine("無効な操作です");
                        break;
                }
            }
        }
        public static bool CompareOrders(Order a, Order b)
        {
            if (a == null && b == null)
                return true;

            if (a == null || b == null)
                return false;

            Dictionary<int, (int totalQty, int price)> AggregateOrderDetails(Order o)
            {
                var dict = new Dictionary<int, (int totalQty, int price)>();

                if (o.orderdetaillist == null || o.orderdetaillist.Count == 0)
                    return dict;

                var groups = o.orderdetaillist.GroupBy(d => d.goods_id);

                foreach (var g in groups)
                {
                    int goodsId = g.Key;
                    int totalQty = g.Sum(x => x.quantity);

                    int priceToUse = g.Select(x => x.price).FirstOrDefault();

                    dict[goodsId] = (totalQty, priceToUse);
                }

                return dict;
            }

            var dictA = AggregateOrderDetails(a);
            var dictB = AggregateOrderDetails(b);

            var keysA = new HashSet<int>(dictA.Keys);
            var keysB = new HashSet<int>(dictB.Keys);

            if (!keysA.SetEquals(keysB))
                return false;

            foreach (var gid in keysA)
            {
                var aItem = dictA[gid];
                var bItem = dictB[gid];

                if (aItem.totalQty != bItem.totalQty)
                    return false;

                if (aItem.price != bItem.price)
                    return false;
            }

            return true;
        }

    }
}
