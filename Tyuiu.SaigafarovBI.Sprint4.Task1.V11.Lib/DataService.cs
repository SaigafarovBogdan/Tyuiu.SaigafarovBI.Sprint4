using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SaigafarovBI.Sprint4.Task1.V11.Lib
{
    public class DataService : ISprint4Task1V11
    {
        public int Calculate(int[] array)
        {
            int sum = 0;
            foreach (int item in array)
            {
                if (item % 2 == 0) sum += item;
            }
            return sum;
        }
    }
}
