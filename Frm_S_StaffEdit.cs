using FlexOrderLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_S_StaffEdit : Form
    {
        string type;
        int id = 0;
        Boolean change_password = false;
        Form parent;
        public Boolean closeparent = false;
        Staff loginstaff;
        Staff beforeeditstaff;
        public Frm_S_StaffEdit(string type, Form parent)
        {
            InitializeComponent();
            this.type = type;
            this.parent = parent;
        }
        public Frm_S_StaffEdit(Staff loginstaff, string type, Form parent)
        {
            InitializeComponent();
            this.type = type;
            this.parent = parent;
            this.loginstaff = loginstaff;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (change_password) 
            {
                txbPassword.ReadOnly = true;
                txbPassword.Text = "";
                txbPassword2.ReadOnly = true;
                txbPassword2.Text = "";
                btnChangePassword.Text = "パスワード変更をONにする";
                change_password = false;
            } 
            else 
            {
                txbPassword.ReadOnly = false;
                txbPassword2.ReadOnly = false;
                btnChangePassword.Text = "パスワード変更をOFFにする";
                change_password = true;
            }
        }
        private void Frm_S_StaffEdit_Load(object sender, EventArgs e)
        {
            if (type == "Add")
            {
                lblTitle.Text = "店員登録";
                rbtnStaff.Checked = true;
            }
            else
            {
                lblTitle.Text = "店員編集";
                lblIdHint.Visible = false;
                id = int.Parse(type);
                if (id == loginstaff.staff_id) 
                {
                    rbtnAdmin.Enabled = false;
                    rbtnStaff.Enabled = false;
                }
                StaffTable staffTable = new StaffTable();
                beforeeditstaff = staffTable.GetStaffById(id);
                txbID.Text = id.ToString();
                txbLastname.Text = beforeeditstaff.staff_lastname;
                txbFirstname.Text = beforeeditstaff.staff_firstname;
                if (beforeeditstaff.is_manager)
                {
                    rbtnAdmin.Checked = true;
                }
                else
                {
                    rbtnStaff.Checked = true;
                }
                txbPassword.ReadOnly = true;
                txbPassword2.ReadOnly = true;
                txbID.ReadOnly = true;
                btnChangePassword.Visible = true;
            }
        }

        private void Frm_S_StaffEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (closeparent) 
            {
                parent.Close();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            StaffTable staffTable = new StaffTable();
            if (type == "Add") 
            {
                Staff newstaff = null;
                int newid;
                bool parseresult = int.TryParse(txbID.Text, out newid);
                string errs = "";
                if(txbID.Text == "") 
                {
                    errs += "スタッフIDを入力してください\n";
                }
                else 
                {
                    
                    if (parseresult && newid > 99999 && newid < 100000000) 
                    {
                        newstaff = staffTable.GetStaffById(newid);
                        if (newstaff != null) 
                        {
                            errs += "このスタッフIDは既に登録されています。\n";
                        }
                        //ここならID OK
                    }
                    else 
                    {
                        errs += "スタッフIDは6~8桁の有効数字を入力してください\n";
                    }
                    
                }
                if(txbFirstname.Text == "" && txbLastname.Text == "") 
                {
                    errs += "姓と名はどちらかを入力してください\n";
                } else if (txbFirstname.Text.Length > 50 || txbLastname.Text.Length > 50) 
                {
                    errs += "姓と名は50文字以下で入力してください\n";
                }
                if (txbPassword.Text == "" || txbPassword2.Text == "")
                {
                    errs += "パスワードを入力してください\n";
                }else if (txbPassword.Text.Length < 6 || txbPassword2.Text.Length < 6)
                {
                    errs += "パスワードは6桁以上で入力してください\n";
                } else if (txbPassword.Text != txbPassword2.Text) 
                {
                    errs += "パスワードは一致していません\n";
                }

                //ここからはInsert処理
                if (errs == "") 
                {
                    string access = rbtnAdmin.Checked ? "管理者" : "店員";
                    DialogResult dret = MessageBox.Show("商品分類：" + newid + "\n" + "姓：" + txbLastname.Text + "\n" + "名：" + txbFirstname.Text + "\n" + "権限：" + access +  "\n" + "\n以上の内容で登録しますか？", "確認",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dret == DialogResult.Yes) 
                    {
                        newstaff = new Staff();
                        newstaff.staff_id = newid;
                        newstaff.staff_lastname = txbLastname.Text;
                        newstaff.staff_firstname = txbFirstname.Text;
                        newstaff.is_manager = rbtnAdmin.Checked;
                        newstaff.staff_password = StaffTable.ComputeSha256Hex(txbPassword2.Text);
                        int cnt = staffTable.Insert(newstaff);
                        if (cnt > 0) 
                        {
                            SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(), "Staff", newid.ToString(), "登録", "");
                            MessageBox.Show(cnt + "件の店員アカウントを登録しました", "登録完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        this.Close();
                    }
                }
                else 
                {
                    MessageBox.Show(errs, "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
            else 
            {
                string errs = "";
                Staff editstaff = new Staff();
                if (txbFirstname.Text == "" && txbLastname.Text == "")
                {
                    errs += "姓と名はどちらかを入力してください\n";
                }
                else if (txbFirstname.Text.Length > 50 || txbLastname.Text.Length > 50)
                {
                    errs += "姓と名は50文字以下で入力してください\n";
                }
                if (change_password) 
                {
                    if (txbPassword.Text == "" || txbPassword2.Text == "")
                    {
                        errs += "パスワードを入力してください\n";
                    }
                    else if (txbPassword.Text.Length < 6 || txbPassword2.Text.Length < 6)
                    {
                        errs += "パスワードは6桁以上で入力してください\n";
                    }
                    else if (txbPassword.Text != txbPassword2.Text)
                    {
                        errs += "パスワードは一致していません\n";
                    }
                }
                if (errs == "")
                {
                    string access = rbtnAdmin.Checked ? "管理者" : "店員";
                    string changepass = change_password ? "あり" : "なし";
                    DialogResult dret = MessageBox.Show("ID：" + txbID.Text + "\n" + "姓：" + txbLastname.Text + "\n" + "名：" + txbFirstname.Text + "\n" + "パスワード変更：" + changepass + "\n" + "権限：" + access + "\n" + "\n以上の内容に変更しますか？", "確認",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dret == DialogResult.Yes)
                    {
                        editstaff.staff_id = id;
                        editstaff.staff_lastname = txbLastname.Text;
                        editstaff.staff_firstname = txbFirstname.Text;
                        editstaff.is_manager = rbtnAdmin.Checked;
                        if (change_password) 
                        {
                            editstaff.staff_password = StaffTable.ComputeSha256Hex(txbPassword2.Text);
                        }
                        else 
                        {
                            editstaff.staff_password = staffTable.GetStaffById(id).staff_password;
                        }
                        int cnt = staffTable.Update(editstaff);
                        if (cnt > 0)
                        {
                            string message = "";
                            if (change_password) 
                            {
                                message += "パスワード変更あり";
                            }
                            if (beforeeditstaff.is_manager != editstaff.is_manager) 
                            {
                                message += ";権限を ";
                                if (beforeeditstaff.is_manager) 
                                {
                                    message += "管理者";
                                }
                                else 
                                {
                                    message += "一般";
                                }
                                message += " から ";
                                if (editstaff.is_manager)
                                {
                                    message += "管理者";
                                }
                                else
                                {
                                    message += "一般";
                                }
                                message += " に変更した";
                            }
                            SecurityLogger.WriteSecurityLog(loginstaff.staff_id.ToString(), "Staff", id.ToString(), "編集", message);
                            MessageBox.Show(cnt + "件の店員アカウントを編集しました", "編集完了",
                                                           MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (loginstaff != null && loginstaff.staff_id == id && change_password)
                            {
                                closeparent = true;
                            }
                            this.Close();
                        }
                        
                    }
                }
                else
                {
                    MessageBox.Show(errs, "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
