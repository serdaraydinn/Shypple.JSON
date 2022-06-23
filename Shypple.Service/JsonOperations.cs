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
        //Gets the root object from response.json
        public Root GetRootObject(string jsonText)
        {
            Root rootObj = new();

            rootObj = JsonConvert.DeserializeObject<Root>(jsonText);
            rootObj.ExchangeRatesList = (List<ExchangeRate>)rootObj.ExchangeRates.Select(e => new ExchangeRate { ExchangeDate = e.Key, ExchangeRateDetails = e.Value }).ToList();

            return rootObj;
        }

        //Reads the json file given as path
        public string ReadJsonAsString(string path)
        {
            JObject o1 = JObject.Parse(File.ReadAllText(path));

            return o1.ToString();
        }

        //Writes json file if needed
        public void WriteJson(SailingOutput sailing, string fileName)
        {
            
            using (StreamWriter file = File.CreateText(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName) + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, sailing);
            }
        }

        public void WriteJson(List<SailingOutput> sailings, string fileName)
        {
            using (StreamWriter file = File.CreateText(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, fileName) + ".json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, sailings);
                
            }
        }
    }
}
