using System;

namespace Task_64
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 64: Задайте значение N.Напишите программу, которая выведет все натуральные числа
            //в промежутке от N до 1.Выполнить с помощью рекурсии.
            //N = 5-> "5, 4, 3, 2, 1"
            //N = 8-> "8, 7, 6, 5, 4, 3, 2, 1"

            while (true)
            {
                int value = IntRead("Введите целое натуральное число: ");

                if (value < 1)
                {
                    Console.WriteLine("Ввели не положительное число");
                    continue;
                }
                Console.WriteLine($"N = {value}-> \"{StringNumbers(value)}\"" );
                Console.ReadKey();
                Console.Clear();

            }

            string StringNumbers(int number, int count = 0)
            {
                if (number == count) return String.Empty;
                else if (number == 1) return $"{number}";
                return $"{number}, " + StringNumbers(number - 1);
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
                Console.Clear();
                return Convert.ToInt32(stringNumber);
            }
        }
    }
}
