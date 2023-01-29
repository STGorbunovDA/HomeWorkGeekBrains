using System;

namespace HomeWork004_ThreeDigitNumberAsNumberOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = new Random().Next(100, 1000);
            Console.WriteLine("Число: " + number);
            string strNumber = number.ToString();
            char с = strNumber[strNumber.Length - 3];
            Console.WriteLine("Сотни: " + с);
            char b = strNumber[strNumber.Length - 2];
            Console.WriteLine("Десятки: " + b);
            char a = strNumber[strNumber.Length - 1];
            
            Console.WriteLine("Единицы: " + a);
            
            
            Console.ReadKey();
        }
    }
}
