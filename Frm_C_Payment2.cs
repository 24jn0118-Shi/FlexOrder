using Newtonsoft.Json.Linq; // 用于解析 JSON，你需要安装 Newtonsoft.Json NuGet 包
using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public partial class Frm_C_Payment2 : Form
    {
        public Frm_C_Payment2(int total)
        {
            InitializeComponent();
        }

        private　async void Frm_C_Payment2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
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

        private async Task<bool> PaymentAsync()
        {
            try
            {
                // 1️⃣ 创建 Customer
                string custJson = await PayjpHelper.CreateCustomerAsync();
                string customerId = JObject.Parse(custJson)["id"].ToString();

                // 2️⃣ 创建 Token
                //string tokenJson = await PayjpHelper.CreateTokenAsync("4242424242424242", "12", "2030", "123");
                string tokenJson = await PayjpHelper.CreateTokenAsync("5555555555554444", "11", "2028", "123");
                string tokenId = JObject.Parse(tokenJson)["id"].ToString();

                // 3️⃣ 绑定 Card 到 Customer
                string cardJson = await PayjpHelper.AddCardToCustomerAsync(customerId, tokenId);
                string cardId = JObject.Parse(cardJson)["id"].ToString();

                // 4️⃣ 扣款
                string chargeJson = await PayjpHelper.ChargeCustomerAsync(customerId, cardId, 1000);

                Console.WriteLine("Customer: " + custJson);
                Console.WriteLine("Token: " + tokenJson);
                Console.WriteLine("Card: " + cardJson);
                Console.WriteLine("Charge: " + chargeJson);

                return ShowChargeResult(chargeJson);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
                return false;
            }
        }

        private bool ShowChargeResult(string chargeJson)
        {
            dynamic charge = Newtonsoft.Json.JsonConvert.DeserializeObject(chargeJson);

            bool paid = charge.paid;
            bool captured = charge.captured;
            string failureCode = charge.failure_code;
            string failureMessage = charge.failure_message;

            StringBuilder result = new StringBuilder();
            result.AppendLine("結果:");

            if (paid && captured && string.IsNullOrEmpty(failureCode))
            {
                result.AppendLine("✅ お支払い成功！");
                result.AppendLine($"お支払い金額: {charge.amount} {charge.currency}");
                result.AppendLine("カード番号: "+"**** **** **** " + charge.card.last4);
            }
            else
            {
                result.AppendLine("❌ お支払い失敗！");
                if (!string.IsNullOrEmpty(failureCode))
                    result.AppendLine($"エラーコード: {failureCode}");
                if (!string.IsNullOrEmpty(failureMessage))
                    result.AppendLine($"エラーメッセージ: {failureMessage}");
            }

            MessageBox.Show(result.ToString(), "お支払い状況");
            return paid && captured && string.IsNullOrEmpty(failureCode);
        }
    }
}
