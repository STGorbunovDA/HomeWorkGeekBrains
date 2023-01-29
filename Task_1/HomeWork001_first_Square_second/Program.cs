using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HomeWork001_first_Square_second
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое число в квадрате: ");
            string stringNumber = Console.ReadLine();
            int numberFirst;
            while (!int.TryParse(stringNumber, out numberFirst))
            {
                Console.WriteLine("Ошибка! Введите первое целое число");
                stringNumber = Console.ReadLine().Trim();
            }
            Console.WriteLine("Введите второе число которое является квадратом первого: ");
            stringNumber = "";
            stringNumber = Console.ReadLine();
            int numberSecond;
            while (!int.TryParse(stringNumber, out numberSecond))
            {
                Console.WriteLine("Ошибка! Введите второе целое число");
                stringNumber = Console.ReadLine().Trim();
            }

            if(Isqrt(numberFirst, numberSecond))
                Console.WriteLine($"Число: {numberFirst}, является квадратом числа: {numberSecond}");
            else Console.WriteLine($"Число: {numberFirst}, не является квадратом числа: {numberSecond}");
            Console.ReadKey();

        }
        static bool Isqrt(int numberFirst, int numberSecond)
        {
            if (numberFirst == 0 || numberSecond == 0)
            {
                Console.WriteLine("Ошибка! Вводи не \"0\"");
                return false;
            }
            else
            {
                int result = numberFirst / numberSecond;
                if(result == numberSecond)
                    return true;
                else
                    return false;
            }
        }
    }
}
