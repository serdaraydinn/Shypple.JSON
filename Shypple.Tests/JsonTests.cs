using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Shypple.Interface;
using Shypple.Service;
using System;
using Xunit;

namespace Shypple.Tests
{
    public class JsonTests
    {
        [Fact]
        public void Test_GetCheapestDirectSailing()
        {
            IJsonOperations jsonOps = new JsonOperations();
            ISailingOperations sailingOps = new SailingOperations();

            string json = jsonOps.ReadJsonAsString("response.json");
            var rootObj = jsonOps.GetRootObject(json);
            
            var x = sailingOps.GetCheapestDirectSailing(rootObj);

            Assert.True(JToken.DeepEquals(ExpectedJson.CheapestDirectSailing, JsonConvert.SerializeObject(x)));
        }

        [Fact]
        public void Test_GetCheapestSailingLegs()
        {
            IJsonOperations jsonOps = new JsonOperations();
            ISailingOperations sailingOps = new SailingOperations();

            string expectedJson = ExpectedJson.CheapestSailingLegs;

            string jsonResult = jsonOps.ReadJsonAsString("response.json");
            var rootObj = jsonOps.GetRootObject(jsonResult);

            var y = sailingOps.GetCheapestSailingLegs(rootObj);

            Assert.True(JToken.DeepEquals(ExpectedJson.CheapestSailingLegs, JsonConvert.SerializeObject(y)));
        }

        [Fact]
        public void Test_GetFastestSailingLegs()
        {
            IJsonOperations jsonOps = new JsonOperations();
            ISailingOperations sailingOps = new SailingOperations();

            string json = jsonOps.ReadJsonAsString("response.json");
            var rootObj = jsonOps.GetRootObject(json);

            var z = sailingOps.GetFastestSailingLegs(rootObj);

            Assert.True(JToken.DeepEquals(ExpectedJson.FastestSailingLegs, JsonConvert.SerializeObject(z)));
        }
    }
}