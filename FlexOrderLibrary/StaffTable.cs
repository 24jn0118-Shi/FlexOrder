using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrderLibrary
{
    public class StaffTable
    {
        public static string ComputeSha256Hex(string input)
        {
            using (var sha = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(input);
                byte[] hash = sha.ComputeHash(bytes);
                var sb = new StringBuilder(hash.Length * 2);
                foreach (byte b in hash)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }
        public Staff Login(int staff_id,string pass)
        {
            Staff staff = null;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Staff WHERE staff_id=@id";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@id", staff_id);

                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);
                if (cnt == 1)
                {
                    string correctpw = table.Rows[0]["staff_password"].ToString();
                    if(correctpw == ComputeSha256Hex(pass)) 
                    {
                        staff = new Staff();
                        staff.staff_id = int.Parse(table.Rows[0]["staff_id"].ToString());
                        staff.staff_lastname = table.Rows[0]["staff_lastname"].ToString();
                        staff.staff_firstname = table.Rows[0]["staff_firstname"].ToString();
                        staff.is_manager = bool.Parse(table.Rows[0]["is_manager"].ToString());
                    }
                    
                }
            }

            return staff;
        }
        public DataTable GetAllStaff()
        {
            DataTable table = new DataTable();
            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Staff";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.Fill(table);
            }
            return table;
        }
        public Staff GetStaffByStaffid(int staff_id)
        {
            Staff staff = null;
            
            return staff;
        }
        public int Insert(Staff staff)
        {

            return -1;
        }
        public int Update(Staff staff)
        {
            return -1;
        }

        public int delete(Staff staff)
        {
            return -1;



        }
    }
}
