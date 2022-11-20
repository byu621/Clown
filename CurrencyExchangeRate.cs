using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clown
{
    class CurrencyExchangeRate
    {
        [JsonProperty("Realtime Currency Exchange Rate")]
        public RealTimeCurrencyExchangeRate RealTimeCurrencyExchangeRate;
    }

    class RealTimeCurrencyExchangeRate
    {
        [JsonProperty("1. From_Currency Code")]
        public string FromCurrencyCode;

        [JsonProperty("2. From_Currency Name")]
        public string FromCurrencyName;

        [JsonProperty("3. To_Currency Code")]
        public string ToCurrencyCode;

        [JsonProperty("4. To_Currency Name")]
        public string ToCurrencyName;

        [JsonProperty("5. Exchange Rate")]
        public string ExchangeRate;

        [JsonProperty("6. Last Refreshed")]
        public string LastRefreshed;

        [JsonProperty("7. Time Zone")]
        public string TimeZone;

        [JsonProperty("8. Bid Price")]
        public string BidPrice;

        [JsonProperty("9. Ask Price")]
        public string AskPrice;
    }
}
