using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SaigafarovBI.Sprint4.Task0.V10.Lib
{
    public class DataService : ISprint4Task0V10
    {
        public int GetSumOddArrEl(int[] array)
        {
            int sum = 0;
            foreach (int i in array)
            {
                if (i % 2 != 0) sum += i;
            }
            return sum;
        }
    }
}
