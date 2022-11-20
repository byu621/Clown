using System.Collections.Generic;
using Newtonsoft.Json;

namespace Clown
{
    class FXDaily
    {
        [JsonProperty("Meta Data")]
        public MetaData MetaData;

        [JsonProperty("Time Series FX (Daily)")]
        public Dictionary<string, OneDate> FunctionName;
    }

    class MetaData
    {
        [JsonProperty("1. Information")] public string information;
        [JsonProperty("2. From Symbol")] public string fromSymbol;
        [JsonProperty("3. To Symbol")] public string toSymbol;
        [JsonProperty("4. Output Size")] public string outputSize;
        [JsonProperty("5. Last Refreshed")] public string lastRefreshed;
        [JsonProperty("6. Time Zone")] public string timeZone;
    }

    class OneDate
    {
        [JsonProperty("1. open")] public string open;
        [JsonProperty("2. high")] public string high;
        [JsonProperty("3. low")] public string low;
        [JsonProperty("4. close")] public string close;
    }
}
