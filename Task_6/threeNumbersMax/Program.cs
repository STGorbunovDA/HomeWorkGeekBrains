using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace threeNumbersMax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое целое число: ");
            string stringNumber = Console.ReadLine();
            int numberFirst;
            while (!int.TryParse(stringNumber, out numberFirst))
            {
                Console.WriteLine("Ошибка! Введите первое целое число");
                stringNumber = Console.ReadLine().Trim();
            }
            Console.WriteLine("Введите второе целое число: ");
            stringNumber = Console.ReadLine();
            int numberSecond;
            while (!int.TryParse(stringNumber, out numberSecond))
            {
                Console.WriteLine("Ошибка! Введите второе целое число");
                stringNumber = Console.ReadLine().Trim();
            }
            Console.WriteLine("Введите третье целое число: ");
            stringNumber = Console.ReadLine();
            int numberThree;
            while (!int.TryParse(stringNumber, out numberThree))
            {
                Console.WriteLine("Ошибка! Введите третье целое число");
                stringNumber = Console.ReadLine().Trim();
            }
            int max = Math.Max(numberFirst, Math.Max(numberSecond, numberThree));
            Console.WriteLine($"{numberFirst} {numberSecond} {numberThree} -> макс. = {max}");
            Console.ReadKey();
        }
    }
}
