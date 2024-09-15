using Tyuiu.SaigafarovBI.Sprint4.Task2.V17.Lib;
namespace Tyuiu.SaigafarovBI.Sprint4.Task2.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void Valid()
        {
            DataService dataService = new DataService();
            int[] numsArray = { 4, 0, 3, 12, 11 };
            Assert.AreEqual(33,dataService.Calculate(numsArray));
        }
    }
}