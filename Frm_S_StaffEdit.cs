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
        String type;
        int id = 0;
        Boolean change_password = false;
        Form parent;
        Boolean closeparent = false;
        Staff staff;
        public Frm_S_StaffEdit(String type, Form parent)
        {
            InitializeComponent();
            this.type = type;
            this.parent = parent;
        }
        public Frm_S_StaffEdit(Staff staff, String type, Form parent)
        {
            InitializeComponent();
            this.type = type;
            this.parent = parent;
            this.staff = staff;
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
                //this.type = "Add";
                lblTitle.Text = "店員追加";
                rbtnStaff.Checked = true;
            }
            else
            {
                //this.type = "Edit";
                lblTitle.Text = "店員編集";
                id = int.Parse(type);
                StaffTable staffTable = new StaffTable();
                Staff staff = staffTable.GetStaffById(id);
                txbID.Text = id.ToString();
                txbLastname.Text = staff.staff_lastname;
                txbFirstname.Text = staff.staff_firstname;
                if (staff.is_manager)
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
                String errs = "";
                if(txbID.Text == "") 
                {
                    errs += "スタッフIDを入力してください\n";
                }
                else 
                {
                    int newid;
                    bool parseresult = int.TryParse(txbID.Text, out newid);
                    if (parseresult && newid > 99999 && newid < 100000000) 
                    {
                        Staff newstaff = staffTable.GetStaffById(newid);
                        if (newstaff != null) 
                        {
                            errs += "このスタッフIDは既に登録されています。\n";
                        }
                        //ここならID OK
                    }
                    else 
                    {
                        errs += "スタッフIDは6~8桁の整数を入力してください\n";
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
                    String access = rbtnAdmin.Checked ? "管理者" : "店員";
                    DialogResult dret = MessageBox.Show("ID："+txbID.Text+"\n"+ "姓：" + txbLastname.Text + "\n" + "名：" + txbFirstname.Text + "\n" + "権限：" + access +  "\n" + "\n\n以上の内容で登録しますか", "確認",
                                                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dret == DialogResult.Yes) 
                    { 
                        Console.WriteLine("Inserted");
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

                String errs = "";




                //Update処理成功なら
                if (staff != null && staff.staff_id == id)
                {
                    closeparent = true;
                }
            }

            
        }
    }
}
