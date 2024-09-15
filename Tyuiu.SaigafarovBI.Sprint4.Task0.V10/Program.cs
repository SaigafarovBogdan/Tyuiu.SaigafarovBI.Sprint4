using Tyuiu.SaigafarovBI.Sprint4.Task0.V10.Lib;
namespace Tyuiu.SaigafarovBI.Sprint4.Task0.V10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = new int[] { 9, 8, 7, 9, 5, 4, 3, 2, 3, 7 };

            Console.WriteLine("Исходный массив:");
            foreach (int num in numsArray)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма нечётных элементов массива:");
            Console.WriteLine(ds.GetSumOddArrEl(numsArray));
            Console.ReadKey();
            
        }
    }
}
