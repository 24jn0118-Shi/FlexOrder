using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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
				INNER JOIN LocalizationGoods AS LG ON G.goods_id = LG.goods_id
                INNER JOIN GoodsGroup AS GG ON G.group_code = GG.group_code
				WHERE is_recommend = 1 AND language_no = @language_no 
				AND is_available = 1 ORDER BY group_sort";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Goods goods = new Goods();

                    goods.goods_id = int.Parse(row["goods_id"].ToString());
                    goods.language_no = language_no;
                    goods.group_code = row["group_code"].ToString();
                    goods.goods_name = row["goods_name"].ToString();
                    goods.goods_detail = row["goods_detail"].ToString();
                    goods.goods_price = int.Parse(row["goods_price"].ToString());
                    goods.goods_image_filename = goods.goods_id.ToString() + ".jpg";
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
				INNER JOIN LocalizationGoods AS LG ON G.goods_id = LG.goods_id 
				WHERE language_no = @language_no 
				ORDER BY RIGHT goods_id ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Goods goods = new Goods();

                    goods.goods_id = int.Parse(row["goods_id"].ToString());
                    goods.language_no = language_no;
                    goods.group_code = row["group_code"].ToString();
                    goods.goods_name = row["goods_name"].ToString();
                    goods.goods_detail = row["goods_detail"].ToString();
                    goods.goods_price = int.Parse(row["goods_price"].ToString());
                    goods.goods_image_filename = goods.goods_id.ToString() + ".jpg";
                    goods.is_recommend = bool.Parse(row["is_recommend"].ToString());
                    goods.is_vegetarian = bool.Parse(row["is_vegetarian"].ToString());
                    goods.is_available = bool.Parse(row["is_available"].ToString());

                    goodsList.Add(goods);
                }
            }
            return goodsList;
        }

        public Goods GetGoodsById(int language_no, int id)
        {
            Goods goods = null;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.*, LG.goods_name, LG.goods_detail 
                            FROM Goods AS G 							
                            INNER JOIN LocalizationGoods AS LG ON G.goods_id = LG.goods_id
                            WHERE LG.language_no = @language_no AND G.goods_id = @goods_id";
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@language_no", language_no);
                    command.Parameters.AddWithValue("@goods_id", id);
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            goods = new Goods();

                            goods.goods_id = id;
                            goods.language_no = language_no;
                            goods.group_code = reader["group_code"]?.ToString();
                            goods.goods_name = reader["goods_name"]?.ToString();
                            goods.goods_detail = reader["goods_detail"]?.ToString();
                            goods.goods_price = Convert.ToInt32(reader["goods_price"]);
                            goods.goods_image_bytes = reader["goods_image"] as byte[];
                            goods.goods_image_filename = goods.goods_id.ToString() + ".jpg";
                            goods.is_recommend = Convert.ToBoolean(reader["is_recommend"]);
                            goods.is_vegetarian = Convert.ToBoolean(reader["is_vegetarian"]);
                            goods.is_available = Convert.ToBoolean(reader["is_available"]);
                        }
                    }
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
				INNER JOIN LocalizationGoods AS LG ON G.goods_id = LG.goods_id
                INNER JOIN GoodsGroup AS GG ON G.group_code = GG.group_code
				WHERE language_no = @language_no AND G.group_code = @group_code
				AND is_available = 1";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.SelectCommand.Parameters.AddWithValue("@group_code", groupcode);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    Goods goods = new Goods();

                    goods.goods_id = int.Parse(row["goods_id"].ToString());
                    goods.language_no = language_no;
                    goods.group_code = row["group_code"].ToString();
                    goods.goods_name = row["goods_name"].ToString();
                    goods.goods_detail = row["goods_detail"].ToString();
                    goods.goods_price = int.Parse(row["goods_price"].ToString());
                    goods.goods_image_filename = goods.goods_id.ToString() + ".jpg";
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
                    INNER JOIN LocalizationGoods AS L ON G.goods_id = L.goods_id 
                    WHERE language_no = 1 
                    ORDER BY goods_id ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }
        public static Dictionary<int, byte[]> GetImagesFromDatabase()
        {
            Dictionary<int, byte[]> imageMap = new Dictionary<int, byte[]>();

            string connectionString = Properties.Settings.Default.DBConnectionString;
            string sql = "SELECT goods_id, goods_image FROM Goods WHERE goods_image IS NOT NULL";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = int.Parse(reader["goods_id"].ToString());
                            if (reader["goods_image"] != DBNull.Value)
                            {
                                byte[] imageData = (byte[])reader["goods_image"];
                                imageMap[id] = imageData;
                            }
                        }
                    }
                }
            }
            return imageMap;
        }
        public int InsertNewGoods(Goods goods)
        {
            int newGoodsId = 0;
            int ret = 0;

            LanguageTable languageTable = new LanguageTable();
            int languagecount = languageTable.GetLanguageCount();

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"
                                INSERT INTO Goods
                                    (goods_price, is_recommend, is_vegetarian, group_code, goods_image, is_available)
                                VALUES
                                    (@goods_price, @is_recommend, @is_vegetarian, @group_code, @goods_image, @is_available);
                                SELECT CAST(SCOPE_IDENTITY() AS int);";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_price", goods.goods_price);
                command.Parameters.AddWithValue("@is_recommend", goods.is_recommend);
                command.Parameters.AddWithValue("@is_vegetarian", goods.is_vegetarian);
                command.Parameters.AddWithValue("@group_code", goods.group_code);
                SqlParameter imageParam = new SqlParameter("@goods_image", SqlDbType.VarBinary);
                imageParam.Value = (object)goods.goods_image_bytes ?? DBNull.Value;
                command.Parameters.Add(imageParam);
                command.Parameters.AddWithValue("@is_available", goods.is_available);
                connection.Open();
                newGoodsId = (int)command.ExecuteScalar();
                Console.WriteLine("Goods に 1 件を追加しました。新ID: " + newGoodsId);
            }
            ret = 0;
            for (int i = 0; i < languagecount; i++)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO LocalizationGoods VALUES(@goods_id, @language_no, @goods_name, @goods_detail)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@goods_id", newGoodsId);
                    command.Parameters.AddWithValue("@language_no", i + 1);
                    command.Parameters.AddWithValue("@goods_name", "");
                    command.Parameters.AddWithValue("@goods_detail", "");
                    connection.Open();
                    ret += command.ExecuteNonQuery();
                }
            }
            Console.WriteLine("LocalizationGoodsに" + ret + "つの言語情報を追加しました");

            return newGoodsId;
        }
        public int UpdateImagesFromBinaryFile(string binaryfilepath) 
        {
            int ret = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (StreamReader sr = new StreamReader(binaryfilepath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    try
                    {
                        string[] parts = line.Split(new[] { ',' }, 2, StringSplitOptions.None);
                        if (parts.Length != 2) continue;

                        int goodsid = int.Parse(parts[0]);
                        string base64Data = parts[1];
                        byte[] imageBytes = Convert.FromBase64String(base64Data);

                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            string sql = @"UPDATE Goods 
                                        SET goods_image = @goods_image 
                                        WHERE goods_id = @goods_id";
                            SqlCommand command = new SqlCommand(sql, connection);

                            command.Parameters.AddWithValue("@goods_id", goodsid);
                            object imageValue = imageBytes ?? (object)DBNull.Value;
                            command.Parameters.AddWithValue("@goods_image", imageValue);

                            connection.Open();
                            int cnt = command.ExecuteNonQuery();
                            if(cnt < 1) 
                            {
                                Console.WriteLine(goodsid + ": 失敗した");
                            }
                            ret += cnt;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"失敗メッセージ: {ex.Message}");
                    }
                }
            }
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
			is_available=@is_available WHERE goods_id = @goods_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_id", goods.goods_id);
                command.Parameters.AddWithValue("@goods_price", goods.goods_price);
                command.Parameters.AddWithValue("@is_recommend", goods.is_recommend);
                command.Parameters.AddWithValue("@is_vegetarian", goods.is_vegetarian);
                command.Parameters.AddWithValue("@group_code", goods.group_code);
                SqlParameter imageParam = new SqlParameter("@goods_image", SqlDbType.VarBinary);
                if (goods.goods_image_bytes != null)
                {
                    imageParam.Value = goods.goods_image_bytes;
                }
                else
                {
                    imageParam.Value = DBNull.Value;
                }
                command.Parameters.Add(imageParam);
                command.Parameters.AddWithValue("@is_available", goods.is_available);

                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;
        }

        public int UpdateGoodsLocalization(Goods goods)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE LocalizationGoods SET goods_name = @goods_name, goods_detail = @goods_detail
                            WHERE goods_id = @goods_id AND language_no = @language_no";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_name", goods.goods_name);
                command.Parameters.AddWithValue("@goods_detail", goods.goods_detail);
                command.Parameters.AddWithValue("@language_no", goods.language_no);
                command.Parameters.AddWithValue("@goods_id", goods.goods_id);

                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;

        }
        public int UpdateAvailable(Goods goods)
        {
            int ret = 0;
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Goods SET is_available= @is_available
                                WHERE goods_id = @goods_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_id", goods.goods_id);
                command.Parameters.AddWithValue("@is_available", !goods.is_available);

                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;
        }

        public int Delete(int goods_id)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM LocalizationGoods WHERE goods_id = @goods_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@goods_id", goods_id);
                connection.Open();

                ret = command.ExecuteNonQuery();
            }
            if (ret > 0)
            {
                using (SqlConnection connection = new SqlConnection(connectionString)) 
                { 
                    string sql = @"DELETE FROM Goods WHERE goods_id = @goods_id";

                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@goods_id", goods_id);

                    connection.Open();
                    ret = command.ExecuteNonQuery();

                }
            }
            
            return ret;
        }
    }
}
