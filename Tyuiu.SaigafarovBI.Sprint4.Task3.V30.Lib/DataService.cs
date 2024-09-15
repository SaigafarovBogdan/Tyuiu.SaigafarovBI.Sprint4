using tyuiu.cources.programming.interfaces.Sprint4;
namespace Tyuiu.SaigafarovBI.Sprint4.Task3.V30.Lib
{
    public class DataService : ISprint4Task3V30
    {
        public int Calculate(int[,] array)
        {
            int maxi = int.MinValue;
            for (int i = 0; i < 5; i++)
            {
                if (array[2,i] > maxi)
                {
                    maxi = array[2,i];
                }
            }
            return maxi;
        }
    }
}
