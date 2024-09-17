using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.SaigafarovBI.Sprint4.Task6.V23.Lib
{
    public class DataService : ISprint4Task6V23
    {
        public int Calculate(string[] array)
        {
            int count = Array.FindAll(array, x => x.Length == 6).Length;
            
            return count;
        }
    }
}
