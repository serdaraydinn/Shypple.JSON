using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shypple.Interface;
using Shypple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shypple.Service
{
    public class JsonOperations : IJsonOperations
    {
        public Root GetRootObject(string jsonText)
        {
            Root rootObj = new();

            rootObj = JsonConvert.DeserializeObject<Root>(jsonText);
            rootObj.ExchangeRatesList = (List<ExchangeRate>)rootObj.ExchangeRates.Select(e => new ExchangeRate { ExchangeDate = e.Key, ExchangeRateDetails = e.Value }).ToList();

            return rootObj;
        }

        public string ReadJsonAsString(string path)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(path));

            return o1.ToString();
        }
    }
}
