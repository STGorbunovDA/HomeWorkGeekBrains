using System;
using System.Linq;

namespace Task_41
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                try
                {
                    Console.Write("Введите элементы (через пробел): ");
                    double[] arr = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);
                    double count = arr.Count(x => x > 0);
                    Console.WriteLine($"Кол-во элементов > 0: {count}");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine($"Ошибка введите число");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
              
            }
        }
    }
}
