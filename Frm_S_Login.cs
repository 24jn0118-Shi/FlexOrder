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
using FlexOrderLibrary;

namespace FlexOrder
{
    public partial class Frm_S_Login : Form
    {
        public Frm_S_Login()
        {
            InitializeComponent();

            //テスト用アカウント
            txbUserId.Text = "100002";
            txbPassword.Text = "100002";
            //テスト用アカウント
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
                StaffTable stafftable = new StaffTable();
                Staff staff = stafftable.Login(useridInt, txbPassword.Text);
                //Login成功なら
                if (staff!=null)
                {
                Frm_S_Mainmenu form = new Frm_S_Mainmenu(staff);
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
            this.Close();
        }
    }
}
