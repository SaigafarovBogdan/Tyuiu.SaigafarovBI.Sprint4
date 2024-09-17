using Tyuiu.SaigafarovBI.Sprint4.Task7.V19.Lib;

namespace Tyuiu.SaigafarovBI.Sprint4.Task7.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            Assert.AreEqual(3, dataService.Calculate(4, 2, "90817264"));
        }
    }
}