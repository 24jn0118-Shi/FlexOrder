using Newtonsoft.Json.Linq; // 用于解析 JSON，你需要安装 Newtonsoft.Json NuGet 包
using System;
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
            if (paytype != "card")
            {
                lblCardNumber.Visible = false;
                lblMY.Visible = false;
                lblSlash.Visible = false;
                lblCvc.Visible = false;
                txtCardNumber.Visible = false;
                txtExpMonth.Visible = false;
                txtExpYear.Visible = false;
                txtCvc.Visible = false;
                btnPay.Visible = false;

            }
            else 
            {
                lblEnter.Visible = false;
                txtCardNumber.Text = "4000000000000002";
                txtExpMonth.Text = "11";
                txtExpYear.Text = "2028";
                txtCvc.Text = "123";
            }
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
            try
            {
                // 1️⃣ Customer
                string custJson = await PayjpHelper.CreateCustomerAsync();
                JObject cust = JObject.Parse(custJson);
                if (cust["error"] != null || cust["error_occurred"] != null)
                {
                    MessageBox.Show("顧客作成エラー: " + cust.ToString());
                    return false;
                }
                string customerId = cust["id"].ToString();

                // 2️⃣ Token
                string tokenJson = await PayjpHelper.CreateTokenAsync(
                    txtCardNumber.Text,
                    txtExpMonth.Text,
                    txtExpYear.Text,
                    txtCvc.Text
                );

                JObject token = JObject.Parse(tokenJson);
                if (token["error"] != null || token["error_occurred"] != null)
                {
                    MessageBox.Show("カードエラー: " + token.ToString());
                    return false;
                }
                string tokenId = token["id"].ToString();

                // 3️⃣ Add Card
                string cardJson = await PayjpHelper.AddCardToCustomerAsync(customerId, tokenId);
                JObject card = JObject.Parse(cardJson);
                if (card["error"] != null || card["error_occurred"] != null)
                {
                    MessageBox.Show("カード追加エラー: " + card.ToString());
                    return false;
                }
                string cardId = card["id"].ToString();

                // 4️⃣ Charge
                string chargeJson = await PayjpHelper.ChargeCustomerAsync(customerId, cardId, total);

                return ShowChargeResult(chargeJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("予期せぬエラー: " + ex.Message);
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
            bool result = ValidateCardInput();
            if (result) 
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
        }

        private bool ValidateCardInput()
        {
            StringBuilder errs = new StringBuilder("");
            if (string.IsNullOrWhiteSpace(txtCardNumber.Text) ||
                txtCardNumber.Text.Length < 13 ||
                txtCardNumber.Text.Length > 19 ||
                !txtCardNumber.Text.All(char.IsDigit))
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
    }
}
