using Shypple.Interface;
using Shypple.Model;
using Shypple.Service;

namespace Shypple.Test
{
    [TestClass]
    public class UnitTest
    {
        private const string Path = "response.json";

        [TestMethod]
        public async void Test_GetCheapestDirectSailing()
        {
            IJsonOperations operations = new JsonOperations();

            var json = operations.ReadJsonAsString(Path);
        }

        public void Test_GetCheapestSailingLegs()
        {

        }
        public void Test_GetFastestSailingLegs()
        {

        }
    }
}