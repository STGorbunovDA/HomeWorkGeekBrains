using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 38: Задайте массив вещественных чисел.
            //Найдите разницу между максимальным и минимальным элементов массива.
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
                    randomArray[i] = rnd.Next(100, 900);
                    Console.Write(randomArray[i] + " ");
                }
                Console.WriteLine();

                double min = Int32.MaxValue;
                double max = Int32.MinValue;

                for (int i = 0; i < randomArray.Length; i++)
                {
                    if (randomArray[i] > max)
                    {
                        max = randomArray[i];
                    }
                    if (randomArray[i] < min)
                    {
                        min = randomArray[i];
                    }
                }

                Console.WriteLine($"всего {randomArray.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
                Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");
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
