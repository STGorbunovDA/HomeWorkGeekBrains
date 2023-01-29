using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HomeWork_Task_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {
                Console.WriteLine("Введите целое число: ");
                string stringNumber = Console.ReadLine();
                int number;
                while (true)
                {
                    if (Regex.IsMatch(stringNumber, @"^[0-9]{1,1}$"))
                    {
                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Ошибка! Введите целое число: ");
                    stringNumber = Console.ReadLine().Trim();
                }
                number = int.Parse(stringNumber);
                if (number == 0)
                    Console.Write($"Будет 0 ");
                else Console.Write($"{number}-> ");


                for (int i = 1; i <= number; i++)
                { 
                    if(i < number)
                        Console.Write($"{i * i * i}, ");
                    else Console.Write($"{i * i * i}");
                }
                Console.ReadKey();
                Console.Clear();
            }
            
        }
    }
}
