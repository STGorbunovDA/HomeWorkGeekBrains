using System;

namespace Task_47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Задача 47.Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
            //m = 3, n = 4.
            //0,5 7 - 2 - 0,2
            //1 - 3,3 8 - 9,9
            //8 7,8 - 7,1 9
            Random rnd = new Random();
            
            while (true)
            {
                int rows = IntRead("Введите кол-во строк двумерного массива: ");
                int columns = IntRead("Введите кол-во столбцов двумерного массива: ");

                double[,] arr = new double[rows, columns];
                
                Console.WriteLine("Ваш двумерный массив: ");
                Console.WriteLine();
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        arr[i, j] = rnd.NextDouble() * 100;
                        Console.Write("{0,6:F2}", arr[i, j]);
                    }
                    Console.WriteLine();
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
                }
                Console.Clear();
                return Convert.ToInt32(stringNumber);
            }
        }
    }
}
