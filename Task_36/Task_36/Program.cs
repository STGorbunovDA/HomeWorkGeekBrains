using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Задача 36: Задайте одномерный массив, заполненный случайными числами. 
            ///Найдите сумму элементов, стоящих на нечётных позициях.
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
                

                int sum = 0;

                for (int i = 0; i < randomArray.Length; i += 2)
                    sum += randomArray[i];

                Console.WriteLine($"Всего {randomArray.Length} чисел, сумма элементов на нечётных позициях = {sum}");
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
