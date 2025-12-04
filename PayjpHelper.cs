using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace FlexOrder
{
    public class PayjpHelper
    {
        public static string SecretKey { get; private set; } // 私钥
        private static readonly string publicKey = "pk_test_fd84d4fb687a43d3f07e63c8"; // 公钥

        // 创建 token
        public static async Task<string> CreateTokenAsync(string cardNumber, string expMonth, string expYear, string cvc)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.pay.jp/v1/");

                var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(publicKey + ":"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", auth);

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("card[number]", cardNumber),
                    new KeyValuePair<string,string>("card[exp_month]", expMonth),
                    new KeyValuePair<string,string>("card[exp_year]", expYear),
                    new KeyValuePair<string,string>("card[cvc]", cvc)
                });

                var response = await client.PostAsync("tokens", content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        // 创建 customer
        public static async Task<string> CreateCustomerAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.pay.jp/v1/");

                var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(SecretKey + ":"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", auth);

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("description","WinFormsUser")
                });

                var response = await client.PostAsync("customers", content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        // 给 customer 添加 card
        public static async Task<string> AddCardToCustomerAsync(string customerId, string token)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.pay.jp/v1/");

                var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(SecretKey + ":"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", auth);

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("card", token)
                });

                var response = await client.PostAsync($"customers/{customerId}/cards", content);
                return await response.Content.ReadAsStringAsync();
            }
        }

        // 使用 customer + card 扣款
        public static async Task<string> ChargeCustomerAsync(string customerId, string cardId, int amount)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.pay.jp/v1/");

                var auth = Convert.ToBase64String(Encoding.ASCII.GetBytes(SecretKey + ":"));
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", auth);

                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string,string>("customer", customerId),
                    new KeyValuePair<string,string>("card", cardId),
                    new KeyValuePair<string,string>("amount", amount.ToString()),
                    new KeyValuePair<string,string>("currency","jpy"),
                    new KeyValuePair<string,string>("description","WinForms Payment")
                });

                var response = await client.PostAsync("charges", content);
                return await response.Content.ReadAsStringAsync();
            }
        }
        public static void LoadKeys()
        {
            string path = "W:\\24JN01卒業制作\\GroupI\\DBReset\\クレジットカード決済\\sk.txt";

            if (!File.Exists(path))
            {
                throw new FileNotFoundException("❌ payjp_secret.txt 不存在！请将密钥文件放在程序目录。");
            }

            SecretKey = File.ReadAllText(path).Trim();

            if (string.IsNullOrEmpty(SecretKey))
            {
                throw new Exception("❌ payjp_secret.txt 内容为空，无法读取密钥！");
            }
        }
    }
}
