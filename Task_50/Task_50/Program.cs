using System;

namespace Task_50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 50.Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
            //и возвращает значение этого элемента или же указание, что такого элемента нет.
            //Например, задан массив:
            //1 4 7 2
            //5 9 2 3
            //8 4 2 4
            //17->такого числа в массиве нет

            Random rnd = new Random();

            while (true)
            {
                int rows = IntRead("Введите кол-во строк двумерного массива: ");
                int columns = IntRead("Введите кол-во столбцов двумерного массива: ");

                int[,] arr = new int[rows, columns];
                Console.WriteLine("Дан двумерный массив: ");

                FillPrintArray(arr);
                Console.WriteLine();
                int seachNumbers = IntRead("Введите искомое число в данном двумерном массиве :");

                int quantity = 0;
                bool flag = false;
                string сoordinates = String.Empty;
                for (int i = 0; i < arr.GetLength(0); i++)
                    for (int j = 0; j < arr.GetLength(1); j++)
                        if (seachNumbers == arr[i, j]) { сoordinates += $"Находится на [{i + 1}:{j + 1}]\n"; flag = true; quantity++; };

                if (flag)
                    Console.WriteLine($"Число найдено\nВстречается {quantity} раз(а)\n{сoordinates}");
                else
                    Console.WriteLine("Число не найдено");
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
