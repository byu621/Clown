using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;

namespace Clown
{
    class ApiController
    {
        private const string URL = "https://www.alphavantage.co/query";
        private string urlParameters = "?api_key=123";

        public FXDaily FXDaily()
        {
            using (var client = new HttpClient())
            {
                var endpoint = "https://www.alphavantage.co/query?function=FX_DAILY&from_symbol=NZD&to_symbol=USD&apikey=6X5SMM2WD7Y3YJ46";
                var result = client.GetStringAsync(endpoint).Result;
                FXDaily a = JsonConvert.DeserializeObject<FXDaily>(result);
                return a;
            }
        }

        public CurrencyExchangeRate CurrencyExchangeRate()
        {
            using (var client = new HttpClient())
            {
                var endpoint =
                    "https://www.alphavantage.co/query?function=CURRENCY_EXCHANGE_RATE&from_currency=NZD&to_currency=USD&apikey=6X5SMM2WD7Y3YJ46";
                var result = client.GetStringAsync(endpoint).Result;
                CurrencyExchangeRate a = JsonConvert.DeserializeObject<CurrencyExchangeRate>(result);
                return a;
            }
        }
    }
}
