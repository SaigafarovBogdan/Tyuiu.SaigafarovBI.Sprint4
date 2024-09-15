using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SaigafarovBI.Sprint4.Task4.V5.Lib
{
    public class DataService : ISprint4Task4V5
    {
        public int Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int sum = 0;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if(matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];
                    }
                }
            }
            return sum;
        }
    }
}
