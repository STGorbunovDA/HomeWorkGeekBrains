using System;

namespace HomeWork005_NumbersMaxMin
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
            if(numberFirst > numberSecond)
                Console.WriteLine($"Число: {numberFirst} > {numberSecond}");
            else Console.WriteLine($"Число: {numberSecond} > {numberFirst}");
            Console.ReadKey();
        }
    }
}
