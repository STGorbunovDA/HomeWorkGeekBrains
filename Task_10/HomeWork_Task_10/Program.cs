using System;

namespace HomeWork_Task_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(100, 1000);
            string strNumber = number.ToString();
            char b = strNumber[strNumber.Length - 2];
            Console.WriteLine($"{number}-> {b}");
            Console.ReadKey();
        }
    }
}
