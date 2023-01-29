using System;

namespace HomeWork003_IntegersBetween
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
                Console.WriteLine("Ошибка! Введите целое число!");
                stringNumber = Console.ReadLine().Trim();
            }
            int i = -number;
            while (i <= number)
            {
                Console.Write(i.ToString() + " ");
                i++;
            }
            Console.WriteLine("Готовченко!");
            Console.ReadKey();
        }
    }
}
