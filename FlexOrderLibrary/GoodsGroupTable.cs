using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
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
                string sql = @"SELECT * FROM Goods
                INNER JOIN GoodsGroup
				WHERE language_no = @language_no";
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

        public DataTable GetAllGroup()
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM GoodsGroup";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }

        public int Insert(GoodsGroup goodsGroup)
        {
            return -1;
        }
        public int Update(GoodsGroup goodsGroup)
        {
            return -1;
        }
        public int Delete(GoodsGroup goodsGroup)
        {
            return -1;
        }

    }
}
