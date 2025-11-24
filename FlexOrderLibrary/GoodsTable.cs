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
				AND goods_available = 1 ORDER BY group_sort";
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
                    goods.goods_available = bool.Parse(row["goods_available"].ToString());

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
                    goods.goods_available = bool.Parse(table.Rows[0]["goods_available"].ToString());
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
				AND goods_available = 1";
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
                    goods.goods_available = bool.Parse(row["goods_available"].ToString());

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

        public int Insert(Goods goods)
        {
            return -1;
        }
        public int Update(Goods goods)
        {
            return -1;
        }
        public int Delete(Goods goods)
        {
            return -1;
        }
    }
}
