using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Test
{
    public class ExpectedJson
    {
        public static string CheapestDirectSailing = /*lang=json,strict*/ "[ { \"origin_port\": \"CNSHA\",\"destination_port\": \"NLRTM\",\"departure_date\": \"2022-02-01\", \"arrival_date\": \"2022-03-01\",\"sailing_code\": \"ABCD\",\"rate\": \"589.30\",\"rate_currency\": \"USD\"}]";

        public static string CheapestSailingLegs = "[ { \"origin_port\": \"CNSHA\",\"destination_port\": \"ESBCN\",\"departure_date\": \"2022-01-29\",\"arrival_date\": \"2022-02-06\",\"sailing_code\": \"ERXQ\",\"rate\": \"261.96\",\"rate_currency\": \"EUR\"},{\"origin_port\": \"ESBCN\",\"destination_port\": \"NLRTM\",\"departure_date\": \"2022-02-16\",\"arrival_date\": \"2022-02-20\",\"sailing_code\": \"ETRG\",\"rate\": \"69.96\",\"rate_currency\": \"USD\"  }]";

        public static string FastestSailingLegs = "[ { \"origin_port\": \"CNSHA\",\"destination_port\": \"ESBCN\",\"departure_date\": \"2022-01-29\",\"arrival_date\": \"2022-02-06\",\"sailing_code\": \"ERXQ\",\"rate\": \"261.96\",\"rate_currency\": \"EUR\"},{\"origin_port\": \"ESBCN\",\"destination_port\": \"NLRTM\",\"departure_date\": \"2022-02-16\",\"arrival_date\": \"2022-02-20\",\"sailing_code\": \"ETRG\",\"rate\": \"69.96\",\"rate_currency\": \"USD\"  }]";
    }
}
