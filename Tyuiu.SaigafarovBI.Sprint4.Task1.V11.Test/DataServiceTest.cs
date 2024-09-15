using Tyuiu.SaigafarovBI.Sprint4.Task1.V11.Lib;
namespace Tyuiu.SaigafarovBI.Sprint4.Task1.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService dataService = new DataService();
            int[] numsArray = new int[] { 2, 6, 5, 5, 1, 5, 6, 5, 5, 5, 1, 5, 3, 6, 6, 1, 6 };
            Assert.AreEqual(dataService.Calculate(numsArray),32);

        }
    }
}