using Tyuiu.SaigafarovBI.Sprint4.Task0.V10.Lib;
namespace Tyuiu.SaigafarovBI.Sprint4.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            int[] numsArray = new int[]{ 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };
            Assert.AreEqual(43, dataService.GetSumOddArrEl(numsArray));
        }
    }
}