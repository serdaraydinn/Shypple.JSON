using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Model
{
    public partial class Root
    {
        [JsonProperty("sailings")]
        public List<Sailing> Sailings { get; set; }

        [JsonProperty("rates")]
        public List<Rate> Rates { get; set; }

        [JsonProperty("exchange_rates")]
        public Dictionary<DateTimeOffset, Dictionary<string, double>> ExchangeRates { get; set; }

        public List<ExchangeRate> ExchangeRatesList { get; set; }

    }
}
