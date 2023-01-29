using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
            //Например, на выходе получается вот такой массив:
            //01 02 03 04
            //12 13 14 05
            //11 16 15 06
            //10 09 08 07

            while (true)
            {
                int rows = IntRead("Введите кол-во строк и столбцов двумерного массива: ");
                int columns = rows;

                if (rows == 0)
                    continue;

                int[,] arr = new int[rows, columns];
                FillArraySpiral(arr);

                Console.Clear();
                Console.WriteLine("Дан двумерный массив заполненный спирально: ");
                PrintArray(arr);

                Console.ReadKey();
                Console.Clear();
            }

            //  Метод заполнения массива по спирали начиная с 1
            void FillArraySpiral(int[,] array)
            {
                int temp = 1, i = 0, j = 0;
                while (temp <= array.GetLength(0) * array.GetLength(1))
                {
                    array[i, j] = temp;
                    temp++;
                    if (i <= j + 1 && i + j < array.GetLength(1) - 1)
                        j++;
                    else if (i < j && i + j >= array.GetLength(0) - 1)
                        i++;
                    else if (i >= j && i + j > array.GetLength(1) - 1)
                        j--;
                    else
                        i--;
                }
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                        Console.Write(array[i, j] + " ");
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
