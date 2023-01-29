using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumberValueTask27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
            //452-> 11
            //82-> 10
            //9012-> 12

            int minus = 1;
            int numberNatural = IntRead("Введите натуральное число: ");
            int lengthNumber = NumberLengt(numberNatural);
            SumNumbers(numberNatural, lengthNumber);
            Console.ReadKey();

            // Функция вывода суммы цифр в числе
            void SumNumbers(int n, int len)
            {
                int sum = 0;
                for (int i = 1; i <= len; i++)
                {
                    sum += n % 10;
                    n /= 10;
                }
                if (minus > 0)
                    Console.WriteLine($"Сумма цифр в числе: {sum}");
                else Console.WriteLine($"Сумма цифр в числе: -{sum}");
            }

            // Функция подсчета цифр в числе
            int NumberLengt(int a)
            {
                if (a == 0)
                    return 1;
                int index = 0;
                while (a > 0)
                {
                    a /= 10;
                    index++;
                }
                return index;
            }

            int IntRead(string stringNumber)
            {
                Console.WriteLine(stringNumber);
                stringNumber = Console.ReadLine().Trim();
                while (!int.TryParse(stringNumber, out int number))
                {
                    Console.WriteLine("Ошибка! Введите целое число!");
                    stringNumber = Console.ReadLine().Trim();
                }
                int cheackNumber = Convert.ToInt32(stringNumber);
                if (cheackNumber < 0)
                {
                    minus = cheackNumber;
                    cheackNumber *= -1;
                }

                return cheackNumber;
            }
        }
    }
}
