using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputArrayTask29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
            //1, 2, 5, 7, 19-> [1, 2, 5, 7, 19]
            //6, 1, 33-> [6, 1, 33]
            Random rnd = new Random();
            while (true)
            {
                int lengthArray = IntRead("Введите длинну массива: ");

                if (lengthArray == 0)
                {
                    Console.Clear();
                    continue;
                }

                int[] randomArray = new int[lengthArray];
                Console.Write($"Числа массива: ");
                for (int i = 0; i < randomArray.Length; i++)
                {
                    randomArray[i] = rnd.Next(1, 9);
                    Console.Write(randomArray[i] + " ");
                }
                Console.ReadKey();
                Console.Clear();
            }


            int IntRead(string stringNumber)
            {
                Console.WriteLine(stringNumber);
                stringNumber = Console.ReadLine().Trim();
                while (!int.TryParse(stringNumber, out int number))
                {
                    Console.WriteLine("Ошибка! Введите целое число!");
                    stringNumber = Console.ReadLine().Trim();
                    Console.Clear();
                }
                return Convert.ToInt32(stringNumber);
            }
        }
    }
}
