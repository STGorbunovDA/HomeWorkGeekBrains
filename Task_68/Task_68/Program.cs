using System;

namespace Task_68
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
            //Даны два неотрицательных числа m и n.
            //m = 2, n = 3->A(m, n) = 9
            //m = 3, n = 2->A(m, n) = 29

            while (true)
            {
                int m = IntRead("Введите M:");
                int n = IntRead("Введите N:");

                if (m < 0 && n < 0)
                {
                    Console.WriteLine("Введи целое натуральное число");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
                Console.ReadKey();
                Console.Clear();
            }

            int Akkerman(int m, int n)
            {
                if (m == 0) return n + 1;
                if (m > 0 && n == 0) return Akkerman(m - 1, 1);
                else return Akkerman(m - 1, Akkerman(m, n - 1));
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
