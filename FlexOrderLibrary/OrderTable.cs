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
            return null;
        }
    }
}
