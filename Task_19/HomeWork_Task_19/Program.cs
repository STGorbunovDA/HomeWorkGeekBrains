using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork_Task_19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите целое, положительное, пятизначное число: ");
                string stringNumber = Console.ReadLine();
                //int number;
                while (true)
                {
                    if (Regex.IsMatch(stringNumber, @"^[0-9]{5,5}$"))
                    {
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Ошибка!Введи целое, положительное, пятизначное число :");
                    stringNumber = Console.ReadLine().Trim();
                    Console.Clear();
                }
                if (stringNumber.Reverse().SequenceEqual(stringNumber))
                    Console.WriteLine($"Число {stringNumber} палиндром!");
                else Console.WriteLine($"Число {stringNumber} не палиндром!");
                Console.ReadKey();
                Console.Clear();
            }  

        }
    }
}
