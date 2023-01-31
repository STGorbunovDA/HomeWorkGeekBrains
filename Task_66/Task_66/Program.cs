using System;

namespace Task_66
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 66: Задайте значения M и N.Напишите программу,
            //которая найдёт сумму натуральных элементов в промежутке от M до N.
            //M = 1; N = 15-> 120
            //M = 4; N = 8. -> 30

            while (true)
            {
                int m = IntRead("Введите M:");
                int n = IntRead("Введите N:");

                if (m <= 0 && n <= 0)
                {
                    Console.WriteLine("Введи целое натуральное число");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.WriteLine($"Сумма элементов от {m} до {n} = {SumNaturalNumbers(m, n)}");
                Console.ReadKey();
                Console.Clear();
            }

            int SumNaturalNumbers(int m, int n)
            {
                if (m == n)
                    return n;
                return n + SumNaturalNumbers(m, n - 1);
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
