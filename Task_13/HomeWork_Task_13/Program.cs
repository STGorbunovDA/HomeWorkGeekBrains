using System;

namespace HomeWork_Task_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(-10000, 10000);
            int number2 = number;
            if (number < 0) number *= -1;
            string result = ThirdDigit(number).ToString();
            if (result == "-1")
                Console.WriteLine($"{number2} -> третьей цифры нет");
            else Console.WriteLine($"{number2} -> {result}");

            Console.ReadKey();
        }

        static int ThirdDigit(int number)
        {
            int result = -1;
            if (number >= 100)
            {
                while (number > 999)
                {
                    number /= 10;
                }
                result = number % 10;
            }
            return result;
        }
    }
}
