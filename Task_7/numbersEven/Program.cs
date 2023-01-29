using System;

namespace numbersEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое число: ");
            string stringNumber = Console.ReadLine();
            int number;
            while (!int.TryParse(stringNumber, out number))
            {
                Console.WriteLine("Ошибка! Введите целое число");
                stringNumber = Console.ReadLine().Trim();
            }
            if (number % 2 == 0)
                Console.WriteLine($"Число {number} чётное");
            else
                Console.WriteLine($"Число {number} нечётное");

            Console.ReadKey();

        }
    }
}
