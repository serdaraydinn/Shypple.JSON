using Shypple.Interface;
using Shypple.Model;
using Shypple.Service;

namespace Shypple.Test
{
    [TestClass]
    public class UnitTest1
    {
        private const string Path = "response.json";

        [TestMethod]
        public void TestMethod1()
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