using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_Payment2 : Form
    {
        public StringBuilder result = new StringBuilder("");
        string paytype;
        int total;
        public Frm_C_Payment2(string paytype, int total)
        {

            InitializeComponent();

            this.paytype = paytype;
            this.total = total;
        }
        private void Frm_C_Payment2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter) 
            {
                if (paytype != "card")
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else 
                {
                    btnPay.PerformClick();
                }
            } else if (e.KeyChar == (char)Keys.Escape) 
            {
                this.Close();
            }
        }
        private void btnPay_Click(object sender, EventArgs e)
        {   
        }
        private bool ValidateCardInput()
        {
            StringBuilder errs = new StringBuilder("");
            if (string.IsNullOrWhiteSpace(cmbCardNumber.Text) ||
                cmbCardNumber.Text.Length < 13 ||
                cmbCardNumber.Text.Length > 19 ||
                !cmbCardNumber.Text.All(char.IsDigit))
            {
                errs.AppendLine("カード番号が正しくありません。");
            }
            if (!int.TryParse(txtExpMonth.Text, out int month) || month < 1 || month > 12)
            {
                errs.AppendLine("有効期限（月）が正しくありません。");
            }
            if (txtExpYear.Text.Length != 4 || !int.TryParse(txtExpYear.Text, out int year) || year < DateTime.Now.Year)
            {
                errs.AppendLine("有効期限（年）が正しくありません。");
            }
            if (string.IsNullOrWhiteSpace(txtCvc.Text) ||
                txtCvc.Text.Length < 3 || txtCvc.Text.Length > 4 ||
                !txtCvc.Text.All(char.IsDigit))
            {
                errs.AppendLine("CVC が正しくありません。");
            }
            if (errs.ToString() != "") 
            {
                MessageBox.Show(errs.ToString(),"Error");
                return false;
            }
            else 
            { 
                return true;
            }
        }
        private void Frm_C_Payment2_Load(object sender, EventArgs e)
        {
            if (paytype != "card")
            {
                if (paytype == "cash")
                {
                    this.Text = "Cash";
                }
                else if (paytype == "em")
                {
                    this.Text = "EMoney";
                }
                lblSlash.Visible = false;
                cmbCardNumber.Visible = false;
                txtExpMonth.Visible = false;
                txtExpYear.Visible = false;
                txtCvc.Visible = false;
                btnPay.Visible = false;
                btnRef.Visible = false;
            }
            else
            {
                this.Text = "CreditCard";
                lblEnter.Visible = false;
                const string READFILE = @"W:\\24JN01卒業制作\\GroupI\\DBReset\\クレジットカード決済\\testcards.txt";
                if (!File.Exists(READFILE))
                {
                    MessageBox.Show(READFILE + "ファイル存在しません", "エラー",
                                             MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    using (StreamReader sr = new StreamReader(READFILE))
                    {
                        while (!sr.EndOfStream)
                        {
                            string line = sr.ReadLine();
                            cmbCardNumber.Items.Add(line);
                        }
                    }
                    cmbCardNumber.SelectedItem = 0;
                }
                txtExpMonth.Text = "11";
                txtExpYear.Text = "2028";
                txtCvc.Text = "123";
            }
        }
        private void btnRef_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "https://docs.pay.jp/v1/testcard",
                UseShellExecute = true
            });
        }
    }
}
