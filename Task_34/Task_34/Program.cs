using System;

namespace Task_34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
            //Напишите программу, которая покажет количество чётных чисел в массиве.
            //[345, 897, 568, 234] -> 2
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

                int count = 0;
                Console.Write($"Чётные числа массива: ");
                for (int i = 0; i < randomArray.Length; i++)
                {
                    if (randomArray[i] % 2 == 0)
                    {
                        Console.Write(randomArray[i] + " ");
                        count++;
                    }    
                }
                Console.WriteLine();
                Console.WriteLine($"из {randomArray.Length} чисел, {count} четных");
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
