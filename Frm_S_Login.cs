using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void Frm_S_Login_Load(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja");
            ApplyResources(this, Thread.CurrentThread.CurrentUICulture.Name);
        }

        private void ApplyResources(Control control, string cultureName)
        {
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(typeof(Frm_C_Index));

            foreach (System.ComponentModel.PropertyDescriptor pd in System.ComponentModel.TypeDescriptor.GetProperties(control))
            {
                if (pd.IsBrowsable && pd.CanResetValue(control) && pd.PropertyType == typeof(string))
                {
                    string resourceName = control.Name + "." + pd.Name;
                    string resourceValue = rm.GetString(resourceName, new CultureInfo(cultureName));

                    if (!string.IsNullOrEmpty(resourceValue))
                    {
                        pd.SetValue(control, resourceValue);
                    }
                }
            }

            foreach (Control childControl in control.Controls)
            {
                ApplyResources(childControl, cultureName);
            }
        }

        private void txbUserId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }

        private void txbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin.PerformClick();
            }
        }
    }
}
