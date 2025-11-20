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





            return goodsGroup;
        }

        public DataTable GetAllGroup()
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT G.*, L1.group_name AS ja, L2.group_name AS en, L3.group_name AS zh, L4.group_name AS ru " +
                    "FROM GoodsGroup AS G INNER JOIN LocalizationGoodsGroup AS L1 ON G.group_code = L1.group_code " +
                    "INNER JOIN LocalizationGoodsGroup AS L2 ON L1.group_code = L2.group_code " +
                    "INNER JOIN LocalizationGoodsGroup AS L3 ON L1.group_code = L3.group_code " +
                    "INNER JOIN LocalizationGoodsGroup AS L4 ON L1.group_code = L4.group_code " +
                    "WHERE L1.language_no = 1 AND L2.language_no = 2 AND L3.language_no = 3 AND L4.language_no = 4 " +
                    "ORDER BY group_sort ASC";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }

        public int Insert(GoodsGroup goodsGroup)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO GoodsGroup VALUES(@group_code, @group_sort)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", goodsGroup.group_code);
                command.Parameters.AddWithValue("@group_sort", goodsGroup.group_sort);


                connection.Open();
                try
                {
                    //ret = command.ExecuteNonQuery();

                    //string sql2 = @"INSERT INTO LocalizationGoodsGroup VALUES(@group_code, @language_no, @group_name)";
                    //SqlCommand command = new SqlCommand(sql2, connection);
                    command.Parameters.AddWithValue("@group_code", goodsGroup.group_code);
                    command.Parameters.AddWithValue("@language_no", goodsGroup.language_no);
                    command.Parameters.AddWithValue("@group_name", goodsGroup.group_name);

                    connection.Open();
                    ret = command.ExecuteNonQuery();


                }
                catch (SqlException ex)
                {
                    Console.WriteLine("エラーメッセージ：" + ex);
                }
            }


            return ret;

        }


        public int Update(GoodsGroup goodsGroup)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE GoodsGroup SET group_sort = @group_sort WHERE group_code = @group_code";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@group_code", goodsGroup.group_code);
                command.Parameters.AddWithValue("@group_sort", goodsGroup.group_sort);


                connection.Open();
                ret = command.ExecuteNonQuery();

                if (ret > 0)
                {
                    string sql2 = @"UPDATE LocalizationGoodsGroup SET language_no=@language_no, 
                                    group_name = @group_name WHERE group_code = @group_code";

                    //SqlCommand command = new SqlCommand(sql2, connection);
                    command.Parameters.AddWithValue("@group_code", goodsGroup.group_code);
                    command.Parameters.AddWithValue("@language_no", goodsGroup.language_no);
                    command.Parameters.AddWithValue("@group_name", goodsGroup.group_name);

                    connection.Open();
                    ret = command.ExecuteNonQuery();


                }

            }
            return ret;

        }


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
        }

    }
}
