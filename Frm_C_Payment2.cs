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
            }
        }
        private async Task<bool> PaymentAsync()
        {
            string logPath = @"W:\24JN01卒業制作\GroupI\DBReset\クレジットカード決済\jsonlog.txt";
            StringBuilder jsonLog = new StringBuilder();

            try
            {
                // 1. Create Customer
                string custJson = await PayjpHelper.CreateCustomerAsync();
                jsonLog.AppendLine("=== CreateCustomer Response ===");
                jsonLog.AppendLine(custJson);

                JObject cust;
                try
                {
                    cust = JObject.Parse(custJson);
                }
                catch
                {
                    MessageBox.Show("顧客作成のAPI応答が不正です:\n" + custJson);
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                if (cust["error"] != null || cust["error_occurred"] != null)
                {
                    MessageBox.Show("顧客作成エラー:\n" + cust.ToString());
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                string customerId = cust["id"]?.ToString();
                if (string.IsNullOrEmpty(customerId))
                {
                    MessageBox.Show("顧客IDが取得できません。\n" + custJson);
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                // 2. Create Token
                string tokenJson = await PayjpHelper.CreateTokenAsync(
                    cmbCardNumber.Text,
                    txtExpMonth.Text,
                    txtExpYear.Text,
                    txtCvc.Text
                );
                jsonLog.AppendLine("\n=== CreateToken Response ===");
                jsonLog.AppendLine(tokenJson);

                JObject token;
                try
                {
                    token = JObject.Parse(tokenJson);
                }
                catch
                {
                    MessageBox.Show("トークン作成のAPI応答が不正です:\n" + tokenJson);
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                if (token["error"] != null || token["error_occurred"] != null)
                {
                    MessageBox.Show("カードエラー:\n" + token.ToString());
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                string tokenId = token["id"]?.ToString();
                if (string.IsNullOrEmpty(tokenId))
                {
                    MessageBox.Show("トークンIDが取得できません。\n" + tokenJson);
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                // 3. Add Card
                string cardJson = await PayjpHelper.AddCardToCustomerAsync(customerId, tokenId);
                jsonLog.AppendLine("\n=== AddCardToCustomer Response ===");
                jsonLog.AppendLine(cardJson);

                JObject card;
                try
                {
                    card = JObject.Parse(cardJson);
                }
                catch
                {
                    MessageBox.Show("カード追加API応答が不正です:\n" + cardJson);
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                if (card["error"] != null || card["error_occurred"] != null)
                {
                    MessageBox.Show("カード追加エラー:\n" + card.ToString());
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                string cardId = card["id"]?.ToString();
                if (string.IsNullOrEmpty(cardId))
                {
                    MessageBox.Show("カードIDが取得できません。\n" + cardJson);
                    File.WriteAllText(logPath, jsonLog.ToString());
                    return false;
                }

                // 4. Charge
                string chargeJson = await PayjpHelper.ChargeCustomerAsync(customerId, cardId, total);
                jsonLog.AppendLine("\n=== Charge Response ===");
                jsonLog.AppendLine(chargeJson);
                File.WriteAllText(logPath, jsonLog.ToString());  // ← ここで保存

                return ShowChargeResult(chargeJson);
            }
            catch (Exception ex)
            {
                jsonLog.AppendLine("\n=== Fatal Exception ===");
                jsonLog.AppendLine(ex.ToString());
                File.WriteAllText(logPath, jsonLog.ToString());

                MessageBox.Show("予期せぬエラー:\n" + ex.Message);
                return false;
            }
        }
        private bool ShowChargeResult(string chargeJson)
        {
            JObject charge = JObject.Parse(chargeJson);
            if (charge["error"] != null)
            {
                result.AppendLine("Chargeエラー：\n" + charge["error"]["message"]);
                return false;
            }
            bool paid = charge["paid"]?.ToObject<bool>() ?? false;
            bool captured = charge["captured"]?.ToObject<bool>() ?? false;
            string failureCode = charge["failure_code"]?.ToString();
            string failureMessage = charge["failure_message"]?.ToString();
            if (paid && captured && string.IsNullOrEmpty(failureCode))
            {
                result.AppendLine("カード決済成功！");
                return true;
            }
            else
            {
                result.AppendLine($"カード決済失敗：{failureCode}\n{failureMessage}");
                return false;
            }
        }
        private async void btnPay_Click(object sender, EventArgs e)
        {   
            btnPay.Enabled = false;
            bool res = ValidateCardInput();
            if (res) 
            {
                bool success = await PaymentAsync();
                if (success)
                {
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    this.DialogResult = DialogResult.Cancel;
                }
                this.Close();
            }
            btnPay.Enabled = true;
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
                lblWarning1.Visible = false;
                lblWarning2.Visible = false;
                lblCardNumber.Visible = false;
                lblMY.Visible = false;
                lblSlash.Visible = false;
                lblCvc.Visible = false;
                cmbCardNumber.Visible = false;
                txtExpMonth.Visible = false;
                txtExpYear.Visible = false;
                txtCvc.Visible = false;
                btnPay.Visible = false;
                btnRef.Visible = false;
            }
            else
            {
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
