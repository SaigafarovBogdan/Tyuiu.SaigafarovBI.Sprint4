using Tyuiu.SaigafarovBI.Sprint4.Task6.V23.Lib;

namespace Tyuiu.SaigafarovBI.Sprint4.Task6.V23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService dataService = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string[] company = new string[] { "Microsoft", "Google", "Apple", "Amazon", "Facebook", "Tesla", "Netflix" };
            Console.WriteLine("Исходный массив:");
            foreach (string companyItem in company)
            {
                Console.WriteLine(companyItem);
            }
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Количество элементов, длина которых равна 6 = " + dataService.Calculate(company));
            Console.ReadKey();
        }
    }
}
