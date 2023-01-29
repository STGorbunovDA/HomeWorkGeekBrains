using System;

namespace Task_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            //Задача 52.Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4

            while (true)
            {
                int rows = IntRead("Введите кол-во строк двумерного массива: ");
                int columns = IntRead("Введите кол-во столбцов двумерного массива: ");
                int[,] arr = new int[rows, columns];
                Console.WriteLine("Дан двумерный массив: ");
                FillPrintArray(arr);

                Console.WriteLine($"\nCреднее арифметическое в каждом столбце:\n");
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    double sum = 0;
                    for (int i = 0; i < arr.GetLength(0); i++)
                    {
                        sum += arr[i, j];
                    }
                    Console.Write($"{sum / arr.GetLength(0)} ");
                }
                //for (int i = 0; i < arr.GetLength(0); i++)
                //{
                //    double arithmeticNumbersColumns = 0;
                //    for (int j = 0; j < arr.GetLength(1); j++)
                //        arithmeticNumbersColumns += arr[j, i];

                //    arithmeticNumbersColumns = Math.Round(arithmeticNumbersColumns / arr.GetLength(1), 2);
                //    Console.WriteLine($"Столбец № {i + 1}: {arithmeticNumbersColumns}");
                //}

                Console.ReadKey();
                Console.Clear();
            }

            void FillPrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = rnd.Next(0, 11);
                        Console.Write(array[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }

            int IntRead(string stringNumber)
            {
                Console.WriteLine(stringNumber);
                stringNumber = Console.ReadLine().Trim();
                while (!int.TryParse(stringNumber, out int number))
                {
                    Console.WriteLine("Ошибка! Введите целое число!");
                    stringNumber = Console.ReadLine().Trim();
                }
                Console.Clear();
                return Convert.ToInt32(stringNumber);
            }
        }      
    }
}
