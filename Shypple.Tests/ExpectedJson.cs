using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Tests
{
    public static class ExpectedJson
    {
        public const string CheapestDirectSailing = "{\"origin_port\":\"ESBCN\",\"destination_port\":\"NLRTM\",\"departure_date\":\"2022-02-16T00:00:00+03:00\",\"arrival_date\":\"2022-02-20T00:00:00+03:00\",\"sailing_code\":\"ETRG\",\"rate\":69.96,\"rate_currency\":\"USD\",\"RateEUR\":60.930151541543275}";

        public const string CheapestSailingLegs = "[{\"origin_port\":\"ESBCN\",\"destination_port\":\"NLRTM\",\"departure_date\":\"2022-02-16T00:00:00+03:00\",\"arrival_date\":\"2022-02-20T00:00:00+03:00\",\"sailing_code\":\"ETRG\",\"rate\":69.96,\"rate_currency\":\"USD\",\"RateEUR\":60.930151541543275},{\"origin_port\":\"ESBCN\",\"destination_port\":\"NLRTM\",\"departure_date\":\"2022-02-15T00:00:00+03:00\",\"arrival_date\":\"2022-03-29T00:00:00+03:00\",\"sailing_code\":\"ETRF\",\"rate\":70.96,\"rate_currency\":\"USD\",\"RateEUR\":61.795697988330566}]";

        public const string FastestSailingLegs = "[{\"origin_port\":\"ESBCN\",\"destination_port\":\"NLRTM\",\"departure_date\":\"2022-02-16T00:00:00+03:00\",\"arrival_date\":\"2022-02-20T00:00:00+03:00\",\"sailing_code\":\"ETRG\",\"rate\":69.96,\"rate_currency\":\"USD\",\"RateEUR\":60.930151541543275},{\"origin_port\":\"ESBCN\",\"destination_port\":\"NLRTM\",\"departure_date\":\"2022-02-15T00:00:00+03:00\",\"arrival_date\":\"2022-03-29T00:00:00+03:00\",\"sailing_code\":\"ETRF\",\"rate\":70.96,\"rate_currency\":\"USD\",\"RateEUR\":61.795697988330566}]";
    }
}
