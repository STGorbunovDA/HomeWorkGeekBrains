using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DegreeTask25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
            //3, 5 -> 243 (3⁵)
            //2, 4 -> 16

            while (true)
            {
                int numberA = IntRead("Введите число A: ");
                int numberB = IntRead("Введите число B: ");
                Degree(numberA, numberB);
                Console.ReadKey();
                Console.Clear();


                // Функция возведения в степень
                void Degree(int a, int b)
                {
                    int result = 1;
                    for (int i = 1; i <= b; i++)
                    {
                        result *= a;
                    }
                    Console.WriteLine($"Число A в степени B: {result}");
                    
                }

                // Функция ввода
                int IntRead(string stringNumber)
                {
                    Console.WriteLine(stringNumber);
                    stringNumber = Console.ReadLine().Trim();
                    while (!int.TryParse(stringNumber, out int number))
                    {
                        Console.WriteLine("Ошибка! Введите целое число!");
                        stringNumber = Console.ReadLine().Trim();
                    }
                    return Convert.ToInt32(stringNumber);
                }
            }
        }
    }
}
