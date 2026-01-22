using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
                            existingItem.quantity = 0;
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
        public static Order NewOrMore(Order a, Order b)
        {
            if (b == null)
                return null;

            Order result = new Order
            {
                order_id = b.order_id,
                order_date = b.order_date,
                order_seat = b.order_seat,
                is_takeout = b.is_takeout
            };

            if (a == null || a.orderdetaillist == null || a.orderdetaillist.Count == 0)
            {
                foreach (var item in b.orderdetaillist)
                {
                    if (item.quantity > 0)
                    {
                        result.orderdetaillist.Add(new OrderDetail
                        {
                            goods_id = item.goods_id,
                            goods_name = item.goods_name,
                            price = item.price,
                            quantity = item.quantity
                        });
                    }
                }
                return result;
            }

            var dictA = a.orderdetaillist
                .GroupBy(d => d.goods_id)
                .ToDictionary(g => g.Key, g => g.Sum(x => x.quantity));

            foreach (var bItem in b.orderdetaillist)
            {
                if (bItem.quantity <= 0)
                    continue;

                int qtyInA = dictA.ContainsKey(bItem.goods_id)
                    ? dictA[bItem.goods_id]
                    : 0;

                int diffQty = bItem.quantity - qtyInA;

                if (diffQty > 0)
                {
                    result.orderdetaillist.Add(new OrderDetail
                    {
                        goods_id = bItem.goods_id,
                        goods_name = bItem.goods_name,
                        price = bItem.price,
                        quantity = diffQty
                    });
                }
            }

            return result;
        }

        public void RemoveZeros()
        {
            if (orderdetaillist == null || orderdetaillist.Count == 0)
                return;

            orderdetaillist.RemoveAll(item => item.quantity <= 0);
        }

        public DataTable GetSalesReportByGroupName(DateTime from, DateTime to, string group_name)
        {
            DataTable table = new DataTable();
            
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT  goods_name, SUM(od.order_quantity * od.goods_price) AS total_amount
                                 FROM OrderDetail AS od INNER JOIN Goods AS g ON od.goods_id = g.goods_id 
                                 INNER JOIN LocalizationGoods AS lg ON od.goods_id = lg.goods_id 
                                 INNER JOIN LocalizationGoodsGroup AS lgg ON g.group_code = lgg.group_code
                                 INNER JOIN [Order] AS o ON od.order_id = o.order_id  WHERE group_name = @group_name
                                 AND order_date BETWEEN @from AND @to　AND lg.language_no = 1 GROUP BY goods_name";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@group_name", group_name); 
                adapter.SelectCommand.Parameters.AddWithValue("@from", from);
                adapter.SelectCommand.Parameters.AddWithValue("@to", to.AddDays(1));

                adapter.Fill(table);
            }
            return table;

        }

        public DataTable GetSalesReportByGoodsName(DateTime from, DateTime to, string goods_name)
        {

            DataTable table = new DataTable();
            TimeSpan span = to - from;
            string format;

            if (span.Days < 4)
            {
                format = "MM/dd HH";
            }
            else
            {
                format = "yyyy/MM/dd";
            }

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @" SELECT  FORMAT(o.order_date, @format) AS datetime, SUM(od.order_quantity * od.goods_price) AS total_amount
								FROM OrderDetail AS od INNER JOIN LocalizationGoods AS lg ON od.goods_id = lg.goods_id 
                                INNER JOIN [Order] AS o ON od.order_id = o.order_id  WHERE goods_name = @goods_name AND
                                order_date BETWEEN @from AND @to GROUP BY FORMAT(o.order_date, @format) ";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@goods_name", goods_name);
                adapter.SelectCommand.Parameters.AddWithValue("@from", from);
                adapter.SelectCommand.Parameters.AddWithValue("@to", to.AddDays(1));
                adapter.SelectCommand.Parameters.AddWithValue("@format", format);



                adapter.Fill(table);
            }
            return table;

        }

    }
}
