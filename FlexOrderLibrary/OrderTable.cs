using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class OrderTable
    {
        public int InsertNewOrder(Order neworder) 
        {
            int ret = 0;
            int newOrderId = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"
                                INSERT INTO [Order]
                                    (order_date, is_takeout)
                                VALUES
                                    (@order_date, @is_takeout);
                                SELECT CAST(SCOPE_IDENTITY() AS int);";

                SqlCommand command = new SqlCommand(sql, connection);
                DateTime dateTimenow = DateTime.Now;
                command.Parameters.AddWithValue("@order_date", dateTimenow);
                command.Parameters.AddWithValue("@is_takeout", neworder.is_takeout);
                connection.Open();
                newOrderId = (int)command.ExecuteScalar();
                Console.WriteLine("Order に 1 件追加しました。新ID: " + newOrderId);
            }
            ret = 0;
            foreach (OrderDetail detail in neworder.orderdetaillist) 
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO OrderDetail VALUES(@order_id, @goods_id, @price, @quantity, @is_provided)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@order_id", newOrderId);
                    command.Parameters.AddWithValue("@goods_id", detail.goods_id);
                    command.Parameters.AddWithValue("@price", detail.price);
                    command.Parameters.AddWithValue("@quantity", detail.quantity);
                    command.Parameters.AddWithValue("@is_provided", detail.is_provided);
                    connection.Open();
                    ret += command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("OrderDetailに" + ret + "件追加しました");
            return newOrderId;
        }

        public DataTable GetPendingOrders()
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT D.*, order_date, order_seat, is_takeout 
                    FROM OrderDetail AS D 
                    INNER JOIN [Order] AS O ON D.order_id = O.order_id 
                    WHERE D.order_id IN (
                            SELECT order_id
                            FROM OrderDetail
                            GROUP BY order_id
                            HAVING MIN(CASE WHEN is_provided = 1 THEN 1 ELSE 0 END) = 0 
                      )
                    AND order_date >= CAST(GETDATE() AS date) 
                    AND order_date < DATEADD(day, 1, CAST(GETDATE() AS date)) 
                    ORDER BY D.order_id ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }

        public DataTable GetHistoryOrders()
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT D.*, order_date, order_seat, is_takeout 
                    FROM OrderDetail AS D 
                    INNER JOIN [Order] AS O ON D.order_id = O.order_id 
                    WHERE order_date >= DATEADD(day, -6, CAST(GETDATE() AS date)) 
                    AND order_date < DATEADD(day, 1, CAST(GETDATE() AS date)) 
                    ORDER BY D.order_id ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }

        public Order GetOrderById(int id) 
        {
            
            OrderTable orderTable = new OrderTable();
            DataTable table = null;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT O.*, goods_name FROM [OrderDetail] AS O INNER JOIN LocalizationGoods AS G 
                                ON O.goods_id = G.goods_id WHERE order_id = @order_id AND language_no = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@order_id", id);

                adapter.Fill(table);
            }

            Order order = null;
            List<OrderDetail> detailList = new List<OrderDetail>();

            foreach (DataRow row in table.Rows)
            {
                if (order == null)
                {
                    order = new Order();
                    order.order_id = id;
                }

                OrderDetail detail = new OrderDetail();
                detail.goods_name = row["goods_name"].ToString();
                detail.price = int.Parse(row["goods_price"].ToString());
                detail.quantity = int.Parse(row["order_quantity"].ToString());
                
                detailList.Add(detail);

            }

            if (order != null)
            {
                order.orderdetaillist = detailList;
            }
            
            return order;
        }

        public int UpdateOrder(Order order)
        {
            int ret = 0;
            int order_id = order.order_id;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM OrderDetail WHERE order_id = @order_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@order_id", order_id);
                connection.Open();

                ret = command.ExecuteNonQuery();
    
            }
            if (ret > 0)
            {
                ret = 0;

                foreach (OrderDetail detail in order.orderdetaillist)
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        string sql = @"INSERT INTO OrderDetail VALUES(@order_id, @goods_id, @price, @quantity, @is_provided)";
                        SqlCommand command = new SqlCommand(sql, connection);
                        command.Parameters.AddWithValue("@order_id", order_id);
                        command.Parameters.AddWithValue("@goods_id", detail.goods_id);
                        command.Parameters.AddWithValue("@price", detail.price);
                        command.Parameters.AddWithValue("@quantity", detail.quantity);
                        command.Parameters.AddWithValue("@is_provided", detail.is_provided);
                        connection.Open();
                        ret += command.ExecuteNonQuery();
                    }
                }
            }
            return ret;
        }

        public int UpdateSeat(int id, int order_seat)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Order SET order_seat = @order_seat
                            WHERE order_id = @ order_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@ordetr_id", id);
                command.Parameters.AddWithValue("@order_seat", order_seat);

                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }

        public int UpdateProvided(int order_id, int goods_id)
        {
            int ret = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE OrderDetail SET is_provided = CASE WHEN is_provided = 1 THEN 0 ELSE 1 END
                                WHERE order_id = @order_id AND goods_id = @goods_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@order_id", order_id);
                command.Parameters.AddWithValue("@goods_id", goods_id);

                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;

        }

        public int Delete(int id)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM OrderDetail WHERE order_id = @order_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@order_id", id);
                connection.Open();

                ret = command.ExecuteNonQuery();
            }
            if (ret > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = @"DELETE FROM Order WHERE goods_id = @goods_id";

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@order_id", id);
                    connection.Open();

                    ret = command.ExecuteNonQuery();

                }
            }

            return ret;

        }
    }
}
