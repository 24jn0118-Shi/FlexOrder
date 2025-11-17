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
				WHERE is_recommend = 1 AND language_no = @language_no 
				AND goods_available = 1";
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
    }
}
