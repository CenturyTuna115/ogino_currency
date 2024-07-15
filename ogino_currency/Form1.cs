using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace ogino_currency
{
    public partial class Form1 : Form
    {
        private const string apiKey = "1a9358162b649831f0daca81";
        public Form1()
        {
            InitializeComponent();
            LoadCurrencies();
        }

        private async void LoadCurrencies()
        {
            var currencies = await GetSupportedCurrencies(apiKey);
            fromCurrencyBox.Items.AddRange(currencies.ToArray());
            toCurrencybox.Items.AddRange(currencies.ToArray());
        }

        private async Task<List<string>> GetSupportedCurrencies(string apiKey)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/codes";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);
                    List<string> currencies = new List<string>();

                    foreach (var code in data["supported_codes"])
                    {
                        currencies.Add(code[0].ToString());
                    }

                    return currencies;
                }
                else
                {
                    throw new Exception("Error retrieving data from the API.");
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toCurrencybox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void fromCurrencyBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void amounttext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // Only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void convertedtxt_ReadOnlyChanged(object sender, EventArgs e)
        {

        }

        private async void convertBTN_Click(object sender, EventArgs e)
        {
            string fromCurrency = fromCurrencyBox.SelectedItem?.ToString();
            string toCurrency = toCurrencybox.SelectedItem?.ToString();
            decimal amount;

            if (fromCurrency == null || toCurrency == null || !decimal.TryParse(amounttext.Text, out amount))
            {
                MessageBox.Show("Please ensure you have selected both currencies and entered a valid amount.");
                return;
            }

            var result = await GetConvertedAmount(apiKey, fromCurrency, toCurrency, amount);
            convertedtxt.Text = $"{result.convertedAmount:F2} {toCurrency}";
            CurrentRatetxtbox.Text = $"1 {fromCurrency} = {result.exchangeRate:F2} {toCurrency}";
        }

        private async Task<(decimal convertedAmount, decimal exchangeRate)> GetConvertedAmount(string apiKey, string fromCurrency, string toCurrency, decimal amount)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://v6.exchangerate-api.com/v6/{apiKey}/pair/{fromCurrency}/{toCurrency}";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string json = await response.Content.ReadAsStringAsync();
                    JObject data = JObject.Parse(json);
                    decimal exchangeRate = data["conversion_rate"].Value<decimal>();
                    decimal convertedAmount = amount * exchangeRate;
                    return (convertedAmount, exchangeRate);
                }
                else
                {
                    throw new Exception("Error retrieving data from the API.");
                }
            }
        }

        private void CurrentRatetxtbox_ReadOnlyChanged(object sender, EventArgs e)
        {

        }
    }
}
