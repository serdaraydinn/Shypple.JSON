namespace Shypple.Model
{
    public class ExchangeRate
    {
        public DateTimeOffset ExchangeDate { get; set; }
        public Dictionary<string,double> ExchangeRateDetails { get; set; }
    }

}