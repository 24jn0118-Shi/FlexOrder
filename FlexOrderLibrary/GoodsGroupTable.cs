using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class GoodsGroupTable
    {
        public List<GoodsGroup> GetAllAvailableGroup(int language_no)
        {
            DataTable table = new DataTable();
            List<GoodsGroup> grouplist = new List<GoodsGroup>();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT L.*, group_sort FROM GoodsGroup AS G 
                                INNER JOIN LocalizationGoodsGroup AS L on G.group_code = L.group_code 
                                WHERE language_no = @language_no AND 
                                L.group_code IN (SELECT group_code FROM Goods WHERE is_available = 1) 
                                ORDER BY group_sort";

                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    GoodsGroup goodsGroup = new GoodsGroup();

                    goodsGroup.group_code = row["group_code"].ToString();
                    goodsGroup.group_sort = int.Parse(row["group_sort"].ToString());
                    goodsGroup.language_no = language_no;
                    goodsGroup.group_name = row["group_name"].ToString();

                    grouplist.Add(goodsGroup);
                }
            }
            return grouplist;
        }

        public List<GoodsGroup> GetGroupByLanguage(int language_no)
        {
            DataTable table = new DataTable();
            List<GoodsGroup> grouplist = new List<GoodsGroup>();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT L.*, group_sort FROM GoodsGroup AS G INNER JOIN
                                LocalizationGoodsGroup AS L on G.group_code = L.group_code WHERE language_no = @language_no";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.Fill(table);

                foreach (DataRow row in table.Rows)
                {
                    GoodsGroup goodsGroup = new GoodsGroup();

                    goodsGroup.group_code = row["group_code"].ToString();
                    goodsGroup.group_sort = int.Parse(row["group_sort"].ToString());
                    goodsGroup.language_no = language_no;
                    goodsGroup.group_name = row["group_name"].ToString();

                    grouplist.Add(goodsGroup);
                }
            }
            return grouplist;
        }
        public GoodsGroup GetGroupByCode(int language_no, String code) 
        {
            GoodsGroup goodsGroup = null;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.group_code, group_sort, L.group_name 
                    FROM GoodsGroup AS G INNER JOIN LocalizationGoodsGroup AS L ON G.group_code = L.group_code 
                    WHERE G.group_code = @goodscode AND L.language_no = @language_no";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@language_no", language_no);
                adapter.SelectCommand.Parameters.AddWithValue("@goodscode", code);

                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);

                if (cnt != 0)
                {
                    goodsGroup = new GoodsGroup();

                    goodsGroup.group_code = table.Rows[0]["group_code"].ToString();
                    goodsGroup.group_sort = int.Parse(table.Rows[0]["group_sort"].ToString());
                    goodsGroup.group_name = table.Rows[0]["group_name"].ToString();
                    goodsGroup.language_no = language_no;
                }
            }

            return goodsGroup;
        }

        public DataTable GetAllGroup()
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT G.*, L1.group_name AS ja, L2.group_name AS en, L3.group_name AS zh, L4.group_name AS ru 
                    FROM GoodsGroup AS G INNER JOIN LocalizationGoodsGroup AS L1 ON G.group_code = L1.group_code 
                    INNER JOIN LocalizationGoodsGroup AS L2 ON L1.group_code = L2.group_code 
                    INNER JOIN LocalizationGoodsGroup AS L3 ON L1.group_code = L3.group_code 
                    INNER JOIN LocalizationGoodsGroup AS L4 ON L1.group_code = L4.group_code 
                    WHERE L1.language_no = 1 AND L2.language_no = 2 AND L3.language_no = 3 AND L4.language_no = 4 
                    ORDER BY group_sort ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }
        public int GetMaxSort() 
        {
            int maxsort = -1;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"SELECT MAX(group_sort) AS m 
                    FROM GoodsGroup";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);

                if (cnt != 0)
                {
                    maxsort = int.Parse(table.Rows[0]["m"].ToString());
                }
            }

            return maxsort;
        }
        public int InsertNewGroup(GoodsGroup goodsGroup)
        {
            int ret = 0;
            String groupcode = goodsGroup.group_code;
            LanguageTable languageTable = new LanguageTable();
            int languagecount = languageTable.GetLanguageCount();

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO GoodsGroup VALUES(@group_code, @group_sort)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", groupcode);
                command.Parameters.AddWithValue("@group_sort", GetMaxSort()+1);

                connection.Open();

                ret = command.ExecuteNonQuery();
                Console.WriteLine("GoodsGroupにGroup" + ret + "件を追加しました");
            }
            
            ret = 0;
            for (int i = 0; i < languagecount; i++)
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string sql = @"INSERT INTO LocalizationGoodsGroup VALUES(@group_code, @language_no, @group_name)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@group_code", groupcode);
                    command.Parameters.AddWithValue("@language_no", i + 1);
                    command.Parameters.AddWithValue("@group_name", goodsGroup.group_name);
                    connection.Open();
                    ret += command.ExecuteNonQuery();
                    goodsGroup.group_name = "";
                }
            }
            Console.WriteLine("LocalizationGoodsGroupにGroup名" + ret + "つの言語情報を追加しました");
            
            return ret;
        }
        public int UpdateGroupName(GoodsGroup goodsGroup)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE LocalizationGoodsGroup SET group_name = @group_name 
                            WHERE group_code = @group_code AND language_no = @language_no";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", goodsGroup.group_code);
                command.Parameters.AddWithValue("@language_no", goodsGroup.language_no);
                command.Parameters.AddWithValue("@group_name", goodsGroup.group_name);

                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;

        }
        public int ExchangeGroupSort(GoodsGroup goodsGroup, int target) 
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE GoodsGroup SET group_sort = @group_sort WHERE group_code = @group_code";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", goodsGroup.group_code);
                command.Parameters.AddWithValue("@group_sort", 0);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE GoodsGroup SET group_sort = @group_sortafter WHERE group_sort = @group_sortbefore";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_sortafter", goodsGroup.group_sort);
                command.Parameters.AddWithValue("@group_sortbefore", target);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE GoodsGroup SET group_sort = @group_sort WHERE group_code = @group_code";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", goodsGroup.group_code);
                command.Parameters.AddWithValue("@group_sort", target);
                connection.Open();
                ret = command.ExecuteNonQuery();
            }
            return ret;
        }

        /*削除できないようにしています
        public int Delete(string group_code)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM LocalizationGoodsGroup WHERE group_code = @group_code";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", group_code);
                connection.Open();

                ret = command.ExecuteNonQuery();

                if (ret > 0)
                {
                    string sql2 = @"DELETE FROM LocalizationGoodsGroup WHERE group_code = @group_code";

                    //SqlCommand command = new SqlCommand(sql2, connection);
                    command.Parameters.AddWithValue("@group_code", group_code);

                    connection.Open();
                    ret = command.ExecuteNonQuery();


                }
            }
            return ret;
        }*/

    }
}
