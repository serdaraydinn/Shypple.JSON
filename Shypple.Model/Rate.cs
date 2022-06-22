using Newtonsoft.Json;

namespace Shypple.Model
{
    public partial class Rate
    {
        [JsonProperty("sailing_code")]
        public string SailingCode { get; set; }

        [JsonProperty("rate")]
        public double RateX { get; set; }

        [JsonProperty("rate_currency")]
        public string RateCurrency { get; set; }
    }
}