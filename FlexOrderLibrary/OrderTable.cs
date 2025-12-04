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
    }
}
