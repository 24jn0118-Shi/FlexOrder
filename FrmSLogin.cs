using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder_Prototype
{
    public partial class FrmSLogin : Form
    {
        public FrmSLogin()
        {
            InitializeComponent();
        }

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

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool check = false;
            int useridInt;
            if (txbUserId.Text=="" || txbPassword.Text=="")
            {
                MessageBox.Show("IDとパスワードを入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!int.TryParse(txbUserId.Text, out useridInt))
            {
                MessageBox.Show("ユーザーIDは数字で入力してください。", "入力エラー", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else { 
                string connectionString = Properties.Settings.Default.DBConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string sql = "SELECT member_password FROM [User] WHERE member_id=@id";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);

                adapter.SelectCommand.Parameters.AddWithValue("@id", useridInt);

                DataTable table = new DataTable();
                int cnt = adapter.Fill(table);
                    if (cnt == 1)
                    {
                        string correctpw = table.Rows[0]["member_password"].ToString();
                        check = correctpw == ComputeSha256Hex(txbPassword.Text);
                    }
            }
            //Login成功なら
            if (check)
            {
                FrmSMainmenu form = new FrmSMainmenu();
                form.ShowDialog();
            }
            else 
            {
                MessageBox.Show("Id、パスワードはどちらかが違います", "ログイン失敗",
                                 MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
