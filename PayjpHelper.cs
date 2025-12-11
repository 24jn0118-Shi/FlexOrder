using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlexOrder
{
    public class PayjpHelper
    {
        public static string SecretKey { get; private set; }
        private static readonly string publicKey = "pk_test_fd84d4fb687a43d3f07e63c8"; // 公钥

        // 创建 token
        public static async Task<string> CreateTokenAsync(string cardNumber, string expMonth, string expYear, string cvc)
        {
            try
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

                    string json = await response.Content.ReadAsStringAsync();
                    return json;
                }
            }
            catch (Exception ex)
            {
                return "CreateTokenエラー：\n" + $"{{\"error_occurred\": true, \"message\": \"{ex.Message}\"}}";
            }
        }

        public static async Task<string> CreateCustomerAsync()
        {
            try
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
            catch (Exception ex)
            {
                return "CreateCustomerエラー：\n" + $"{{\"error_occurred\": true, \"message\": \"{ex.Message}\"}}";
            }
        }

        public static async Task<string> AddCardToCustomerAsync(string customerId, string token)
        {
            try
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
            catch (Exception ex)
            {
                return "AddCardToCustomerエラー：\n" + $"{{\"error_occurred\": true, \"message\": \"{ex.Message}\"}}";
            }
        }

        public static async Task<string> ChargeCustomerAsync(string customerId, string cardId, int amount)
        {
            try
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
            catch (Exception ex)
            {
                return "ChargeCustomerエラー：\n" + $"{{\"error_occurred\": true, \"message\": \"{ex.Message}\"}}";
            }
        }
        public static void LoadKeys()
        {

            string path = "W:\\24JN01卒業制作\\GroupI\\DBReset\\クレジットカード決済\\sk.txt";

            if (!File.Exists(path))
            {
                MessageBox.Show(path + "ファイル存在しません", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            SecretKey = File.ReadAllText(path).Trim();

            if (string.IsNullOrEmpty(SecretKey))
            {
                MessageBox.Show(path + "ファイルに内容ありません", "エラー",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Console.WriteLine("Key Loaded Form File.");
        }
    }
}
