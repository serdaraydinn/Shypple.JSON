using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Model
{
    public partial class SailingOutput
    {
        [JsonProperty("origin_port")]
        public string OriginPort { get; set; }

        [JsonProperty("destination_port")]
        public string DestinationPort { get; set; }

        [JsonProperty("departure_date")]
        public DateTimeOffset DepartureDate { get; set; }

        [JsonProperty("arrival_date")]
        public DateTimeOffset ArrivalDate { get; set; }

        [JsonProperty("sailing_code")]
        public string SailingCode { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("rate_currency")]
        public string RateCurrency { get; set; }

        public double RateEUR { get; set; }
    }

}
