using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shypple.Interface;
using Shypple.Model;
using Shypple.Service;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        private const string Path = "response.json";

        static void Main(string[] args)
        {

            IJsonOperations jsonOperations = new JsonOperations();
            ISailingOperations sailingOperations = new SailingOperations();

            string json = jsonOperations.ReadJsonAsString(Path);

            Root rootObj = jsonOperations.GetRootObject(json);
            var x = sailingOperations.GetCheapestDirectSailing(rootObj);
            var y = sailingOperations.GetCheapestSailingLegs(rootObj);
            var z = sailingOperations.GetFastestSailingLegs(rootObj);

        }
    }
}