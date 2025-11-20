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
        public Staff GetStaffById(int staff_id)
        {
            Staff staff = null;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT * FROM Staff WHERE staff_id=@staff_id";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@staff_id", staff_id);

                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);

                if (cnt != 0)
                {
                    staff = new Staff();

                    staff.staff_id = int.Parse(table.Rows[0]["staff_id"].ToString());
                    staff.staff_lastname = table.Rows[0]["staff_lastname"].ToString();
                    staff.staff_firstname = table.Rows[0]["staff_firstname"].ToString();
                    staff.is_manager = (bool)table.Rows[0]["is_manager"];
                    staff.staff_password = table.Rows[0]["staff_password"].ToString();
                }
            }
            return staff;
        }
        public int Insert(Staff staff)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"INSERT INTO Staff VALUES(@staff_id,@staff_lastname,@staff_firstname,@is_manager,@staff_password)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@staff_id", staff.staff_id);
                command.Parameters.AddWithValue("@staff_lastname", staff.staff_lastname);
                command.Parameters.AddWithValue("@staff_firstname", staff.staff_firstname);
                command.Parameters.AddWithValue("@is_manager", staff.is_manager);
                command.Parameters.AddWithValue("@staff_password", staff.staff_password);

                connection.Open();
                try
                {
                    ret = command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("エラーメッセージ："+ex);
                }
            }
            return ret;
        }
        public int Update(Staff staff)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"UPDATE Staff SET staff_lastname=@staff_lastname, staff_firstname=@staff_firstname,
			is_manager=@is_manager, staff_password=@staff_password WHERE staff_id = @staff_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@staff_id", staff.staff_id);
                command.Parameters.AddWithValue("@staff_lastname", staff.staff_lastname);
                command.Parameters.AddWithValue("@staff_firstname", staff.staff_firstname);
                command.Parameters.AddWithValue("@is_manager", staff.is_manager);
                command.Parameters.AddWithValue("@staff_password", staff.staff_password);

                connection.Open();
                ret = command.ExecuteNonQuery();

            }
            return ret;
        }

        public int Delete(int staffid)
        {
            int ret = 0;

            string connectionString = Properties.Settings.Default.DBConnectionString;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = @"DELETE FROM Staff WHERE staff_id=@staff_id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@staff_id", staffid);
                connection.Open();

                ret = command.ExecuteNonQuery();
            }
            return ret;
        }
    }
}
