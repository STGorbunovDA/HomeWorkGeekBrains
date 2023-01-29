using System;

namespace HomeWork_Task_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите номер дня недели от 1 до 7: ");
            string stringNumber = Console.ReadLine();
            int numberDay = -1;
            while (true)
            {
                if (!int.TryParse(stringNumber, out numberDay))
                    Console.Write("Ошибка! Введите целое число. ");
                if (numberDay < 1 || numberDay > 7)
                    Console.WriteLine("В диапозоне от 1 до 7");
                else break;
                stringNumber = Console.ReadLine().Trim();
                Console.Clear();
            }
            string[] day_of_week = { "", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

            Console.WriteLine($"{numberDay} -> {day_of_week[numberDay]}");
            if (numberDay > 0 && numberDay <= 5)
                Console.WriteLine($"Сегодня рабочий день");
            else Console.WriteLine($"Сегодня выходной день");
            Console.ReadKey();
        }
    }
}
