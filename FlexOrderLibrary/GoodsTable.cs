using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class GoodsTable
    {
        public List<Goods> GetRecommendGoods(int language_no)
        {
            DataTable table = new DataTable();
            List<Goods> goodsList = new List<Goods>();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.*, goods_name, goods_detail FROM Goods AS G 							
				INNER JOIN LocalizationGoods AS LG ON G.goods_code = LG.goods_code
                INNER JOIN GoodsGroup AS GG ON G.group_code = GG.group_code
				WHERE is_recommend = 1 AND language_no = @language_no 
				AND is_available = 1 ORDER BY group_sort";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Goods goods = new Goods();

                    goods.goods_code = row["goods_code"].ToString();
                    goods.language_no = language_no;
                    goods.group_code = row["group_code"].ToString();
                    goods.goods_name = row["goods_name"].ToString();
                    goods.goods_detail = row["goods_detail"].ToString();
                    goods.goods_price = int.Parse(row["goods_price"].ToString()); 
                    goods.goods_image = row["goods_image"].ToString();
                    goods.is_recommend = bool.Parse(row["is_recommend"].ToString());
                    goods.is_vegetarian = bool.Parse(row["is_vegetarian"].ToString());
                    goods.is_available = bool.Parse(row["is_available"].ToString());

                    goodsList.Add(goods);
                }
            }
            return goodsList;
        }
        public List<Goods> GetAllGoodsList(int language_no)
        {
            DataTable table = new DataTable();
            List<Goods> goodsList = new List<Goods>();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.*, goods_name, goods_detail FROM Goods AS G 
				INNER JOIN LocalizationGoods AS LG ON G.goods_code = LG.goods_code 
				WHERE language_no = @language_no 
				ORDER BY goods_image ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Goods goods = new Goods();

                    goods.goods_code = row["goods_code"].ToString();
                    goods.language_no = language_no;
                    goods.group_code = row["group_code"].ToString();
                    goods.goods_name = row["goods_name"].ToString();
                    goods.goods_detail = row["goods_detail"].ToString();
                    goods.goods_price = int.Parse(row["goods_price"].ToString());
                    goods.goods_image = row["goods_image"].ToString();
                    goods.is_recommend = bool.Parse(row["is_recommend"].ToString());
                    goods.is_vegetarian = bool.Parse(row["is_vegetarian"].ToString());
                    goods.is_available = bool.Parse(row["is_available"].ToString());

                    goodsList.Add(goods);
                }
            }
            return goodsList;
        }

        public Goods GetGoodsByCode(int language_no, String code) 
        {
            Goods goods = null;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.*, goods_name, goods_detail FROM Goods AS G 							
				INNER JOIN LocalizationGoods AS LG ON G.goods_code = LG.goods_code
				WHERE language_no = @language_no AND G.goods_code = @goodscode";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.SelectCommand.Parameters.AddWithValue("@goodscode", code);

                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);

                if (cnt != 0)
                {
                    goods = new Goods();

                    goods.goods_code = code;
                    goods.language_no = language_no;
                    goods.group_code = table.Rows[0]["group_code"].ToString();
                    goods.goods_name = table.Rows[0]["goods_name"].ToString();
                    goods.goods_detail = table.Rows[0]["goods_detail"].ToString();
                    goods.goods_price = int.Parse(table.Rows[0]["goods_price"].ToString());
                    goods.goods_image = table.Rows[0]["goods_image"].ToString();
                    goods.is_recommend = bool.Parse(table.Rows[0]["is_recommend"].ToString());
                    goods.is_vegetarian = bool.Parse(table.Rows[0]["is_vegetarian"].ToString());
                    goods.is_available = bool.Parse(table.Rows[0]["is_available"].ToString());
                }
            }
            return goods;
        }
        public List<Goods> GetGoodsByGroup(int language_no, String groupcode)
        {
            DataTable table = new DataTable();
            List<Goods> goodsList = new List<Goods>();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.*, goods_name, goods_detail FROM Goods AS G 							
				INNER JOIN LocalizationGoods AS LG ON G.goods_code = LG.goods_code
                INNER JOIN GoodsGroup AS GG ON G.group_code = GG.group_code
				WHERE language_no = @language_no 
				AND is_available = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.SelectCommand.Parameters.AddWithValue("@groupcode", groupcode);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Goods goods = new Goods();

                    goods.goods_code = row["goods_code"].ToString();
                    goods.language_no = language_no;
                    goods.group_code = row["group_code"].ToString();
                    goods.goods_name = row["goods_name"].ToString();
                    goods.goods_detail = row["goods_detail"].ToString();
                    goods.goods_price = int.Parse(row["goods_price"].ToString());
                    goods.goods_image = row["goods_image"].ToString();
                    goods.is_recommend = bool.Parse(row["is_recommend"].ToString());
                    goods.is_vegetarian = bool.Parse(row["is_vegetarian"].ToString());
                    goods.is_available = bool.Parse(row["is_available"].ToString());

                    goodsList.Add(goods);
                }
            }
            return goodsList;
        }
        public DataTable GetAllGoods()
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.*, goods_name 
                    FROM Goods AS G 
                    INNER JOIN LocalizationGoods AS L ON G.goods_code = L.goods_code 
                    WHERE language_no = 1 
                    ORDER BY RIGHT(G.goods_code, 4) ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }
        public String GetLastGoodsNo() 
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT TOP 1 RIGHT(goods_code, 4) AS res 
                    FROM Goods 
                    ORDER BY res DESC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
                return table.Rows[0]["res"].ToString();
            }
        }
        public int InsertNewGoods(Goods goods)
        {
            int ret = 0;
            LanguageTable languageTable = new LanguageTable();
            int languagecount = languageTable.GetLanguageCount();

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO Goods VALUES(@goods_code,@goods_price,
			@is_recommend,@is_vegetarian,@group_code,@goods_image,@is_available)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_code", goods.goods_code);
                command.Parameters.AddWithValue("@goods_price", goods.goods_price);
                command.Parameters.AddWithValue("@is_recommend", goods.is_recommend);
                command.Parameters.AddWithValue("@is_vegetarian", goods.is_vegetarian);
                command.Parameters.AddWithValue("@group_code", goods.group_code);
                command.Parameters.AddWithValue("@goods_image", goods.goods_image);
                command.Parameters.AddWithValue("@is_available", goods.is_available);


                connection.Open();

                ret = command.ExecuteNonQuery();
                Console.WriteLine("Goodsに" + ret + "件を追加しました");
            }

            ret = 0;
            for (int i = 0; i < languagecount; i++)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO LocalizationGoods VALUES(@goods_code, @language_no, @goods_name, @goods_detail)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@goods_code", goods.goods_code);
                    command.Parameters.AddWithValue("@language_no", i + 1);
                    command.Parameters.AddWithValue("@goods_name", "");
                    command.Parameters.AddWithValue("@goods_detail", "");
                    connection.Open();
                    ret += command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("LocalizationGoodsに" + ret + "つの言語情報を追加しました");

            return ret;
        }
        public int Update(Goods goods)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Goods SET goods_price=@goods_price,is_recommend=@is_recommend,
			is_vegetarian=@is_vegetarian,group_code=@group_code,goods_image=@goods_image,
			is_available=@is_available WHERE goods_code = @goods_code";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_code", goods.goods_code);
                command.Parameters.AddWithValue("@goods_price", goods.goods_price);
                command.Parameters.AddWithValue("@is_recommend", goods.is_recommend);
                command.Parameters.AddWithValue("@is_vegetarian", goods.is_vegetarian);
                command.Parameters.AddWithValue("@group_code", goods.group_code);
                command.Parameters.AddWithValue("@goods_image", goods.goods_image);
                command.Parameters.AddWithValue("@is_available", goods.is_available);

                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;
        }

        public int UpdateGoodsName(Goods goods)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE LocalizationGoods SET goods_name = @goods_name 
                            WHERE goods_code = @goods_code AND language_no = @language_no";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", goods.goods_code);
                command.Parameters.AddWithValue("@language_no", goods.language_no);
                command.Parameters.AddWithValue("@group_name", goods.goods_name);

                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;

        }
        public int UpdateAvailable(string goods_code)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Goods SET is_available=(CASE WHEN is_available = 0 THEN 1 ELSE 0 END)
                                WHERE goods_code = @goods_code";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_code", goods_code);

                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;
        }

        public int Delete(string goods_code)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM LocalizationGoods WHERE goods_code = @goods_code";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_code", goods_code);
                connection.Open();

                ret = command.ExecuteNonQuery();
            }
            if (ret > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                { 
                    string sql = @"DELETE FROM Goods WHERE goods_code = @goods_code";

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@goods_code", goods_code);

                    connection.Open();
                    ret = command.ExecuteNonQuery();

                }
            }
            
            return ret;
        }
    }
}
