using Shypple.Interface;
using Shypple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Service
{
    public class SailingOperations : ISailingOperations
    {

        private List<SailingOutput> getSailings(Root rootObject)
        {
            List<SailingOutput> result = new List<SailingOutput>();

            result = (from s in rootObject.Sailings
                      join b in rootObject.Rates on s.SailingCode equals b.SailingCode
                      select new SailingOutput()
                      {
                          SailingCode = b.SailingCode,
                          ArrivalDate = s.ArrivalDate,
                          DepartureDate = s.DepartureDate,
                          DestinationPort = s.DestinationPort,
                          OriginPort = s.OriginPort,
                          Rate = b.RateX,
                          RateCurrency = b.RateCurrency,
                          RateEUR = b.RateX / getRateEUR(s.DepartureDate, b.RateCurrency, rootObject.ExchangeRatesList)
                      }).ToList();

            return result;
        }

        private double getRateEUR(DateTimeOffset departureDate, string rateCurrency, List<ExchangeRate> exchangeRatesList)
        {
            double exchangeRate = exchangeRatesList.First(x => x.ExchangeDate == departureDate).ExchangeRateDetails
                                                   .GetValueOrDefault(rateCurrency.ToLower());
            if (rateCurrency.ToLower() == "eur")
                return 1;
            else
                return exchangeRate;
        }


        public SailingOutput GetCheapestDirectSailing(Root rootObject)
        {
            List<SailingOutput> sailings = getSailings(rootObject);

            return sailings.Aggregate((r1, r2) => r1.RateEUR < r2.RateEUR ? r1 : r2); ;
        }

        public List<SailingOutput> GetCheapestSailingLegs(Root rootObject)
        {
            List<SailingOutput> result = getSailings(rootObject);

            var x = result.OrderBy(r => r.RateEUR)
                         .GroupBy(x => new { x.OriginPort, x.DestinationPort })
                         .Select(grp => grp.ToList())
                         .FirstOrDefault();

            return x;
        }

        public List<SailingOutput> GetFastestSailingLegs(Root rootObject)
        {
            List<SailingOutput> result = getSailings(rootObject);

            return result.OrderBy(r => (r.ArrivalDate - r.DepartureDate).TotalDays).GroupBy(x => new { x.OriginPort, x.DestinationPort })
                         .Select(grp => grp.ToList())
                         .FirstOrDefault();

        }

    }
}
