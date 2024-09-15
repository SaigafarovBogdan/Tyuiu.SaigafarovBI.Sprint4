using Tyuiu.SaigafarovBI.Sprint4.Task3.V30.Lib;

namespace Tyuiu.SaigafarovBI.Sprint4.Task3.V30.Test
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
                {2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6},
                { 3, 3, 2, 1, 5},
                { 6, 4, 1, 3, 3},
                { 5, 1, 1, 6, 4}
            };
            Assert.AreEqual(5, dataService.Calculate(mas));
        }
    }
}