using Tyuiu.SaigafarovBI.Sprint4.Task3.V30.Lib;

namespace Tyuiu.SaigafarovBI.Sprint4.Task3.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] mas = new int[5, 5]
            {
                {2, 4, 3, 5, 1 },
                { 6, 6, 1, 2, 6},
                { 3, 3, 2, 1, 5},
                { 6, 4, 1, 3, 3},
                { 5, 1, 1, 6, 4}
            };
            int rows = mas.GetLength(0);
            int cols = mas.GetLength(1);

            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{mas[i, j]} \t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Максимальный элемент в 3 строчке = " + dataService.Calculate(mas));
            Console.ReadKey();
        }
    }
}
