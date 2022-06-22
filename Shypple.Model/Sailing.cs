using Newtonsoft.Json;

namespace Shypple.Model
{
    public partial class Sailing
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
    }
}

