using Tyuiu.SaigafarovBI.Sprint4.Task4.V5.Lib;
namespace Tyuiu.SaigafarovBI.Sprint4.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService dataService = new DataService();
            int[,] mas = new int[5, 5]
            {
                {6, 3, 6, 6, 7 },
                { 9, 8, 9, 7, 9},
                {5, 6, 8, 7, 5},
                { 8, 5, 6, 5, 3},
                { 3, 9, 9, 8, 8}
            };
            Assert.AreEqual(70, dataService.Calculate(mas));
        }
    }
}