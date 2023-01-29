using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
            //Например, даны 2 матрицы:
            //2 4 | 3 4
            //3 2 | 3 3
            //Результирующая матрица будет:
            //18 20
            //15 18
            Random rnd = new Random();

            while (true)
            {
                int rowsOneMatrix = IntRead("Введите кол-во строк 1-й матрицы: ");
                int columnsOneMatrix = IntRead("Введите число столбцов 1-й матрицы и строк 2-й матрицы: ");
                int rowsTwoMatrix = columnsOneMatrix;
                int columnsTwoMatrix = IntRead("Введите число столбцов 2-й матрицы: ");
                
                if (rowsOneMatrix == 0 || columnsOneMatrix == 0 || columnsTwoMatrix == 0)
                    continue;
                int[,] firstMartrix = new int[rowsOneMatrix, columnsOneMatrix];
                FillArray(firstMartrix, 1, 10);
                Console.WriteLine("Дана 1-ая матрица: ");
                PrintArray(firstMartrix);
                Console.WriteLine();
                int[,] secomdMartrix = new int[rowsTwoMatrix, columnsTwoMatrix];
                FillArray(secomdMartrix, 1, 10);
                Console.WriteLine("Дана 2-ая матрица: ");
                PrintArray(secomdMartrix);
                Console.WriteLine();

                int[,] resultMultiplyMatrix = new int[rowsOneMatrix, columnsTwoMatrix];
                Console.WriteLine("Результат перемножения двух матриц: ");
                MultiplyMatrix(firstMartrix, secomdMartrix, resultMultiplyMatrix);
                PrintArray(resultMultiplyMatrix);


                Console.ReadKey();
                Console.Clear();
            }
            //Метод перемножения двух матриц
            void MultiplyMatrix(int[,] firstMartrix, int[,] secomdMartrix, int[,] resultMatrix)
            {
                for (int i = 0; i < resultMatrix.GetLength(0); i++)
                {
                    for (int j = 0; j < resultMatrix.GetLength(1); j++)
                    {
                        int sum = 0;
                        for (int k = 0; k < firstMartrix.GetLength(1); k++)
                        {
                            sum += firstMartrix[i, k] * secomdMartrix[k, j];
                        }
                        resultMatrix[i, j] = sum;
                    }
                }
            }

            void FillArray(int[,] array, int minValue, int maxValue)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                        array[i, j] = rnd.Next(minValue, maxValue - 1);
                    Console.WriteLine();
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
