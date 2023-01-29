using System;

namespace HomeWork008_IntegersBetween_even
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
            if( number > 0)
            {
                int i = 0;
                while (i <= number)
                {
                    if (i % 2 == 0)
                        Console.Write(i + " ");
                    i++;
                }
                Console.WriteLine("Готовченко!");
                Console.ReadKey();
            }
            else
            {
                int i = number;
                int value = -number;
                while (i <= value)
                {
                    if (i % 2 == 0)
                        Console.Write(i.ToString() + " ");
                    i++;
                }
                Console.WriteLine("Готовченко!");
                Console.ReadKey();
            }
            
        }
    }
}
