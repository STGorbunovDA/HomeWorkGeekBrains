class Program
{
    static void Main()
    {
        int[,] a = { { 7, 3, 2 }, { 4, 9, 6 }, { 1, 8, 5 } };

        // Преобразуем двумерный массив в одномерный для удобства сортировки
        int[] flattenedArray = new int[a.GetLength(0) * a.GetLength(1)];
        int index = 0;
        for (int row = 0; row < a.GetLength(0); row++)
        {
            for (int col = 0; col < a.GetLength(1); col++)
            {
                flattenedArray[index] = a[row, col];
                index++;
            }
        }

        // Сортируем одномерный массив
        Array.Sort(flattenedArray);

        // Восстанавливаем отсортированные значения в исходном двумерном массиве
        index = 0;
        for (int row = 0; row < a.GetLength(0); row++)
        {
            for (int col = 0; col < a.GetLength(1); col++)
            {
                a[row, col] = flattenedArray[index];
                index++;
            }
        }

        // Выводим отсортированный массив на печать
        for (int row = 0; row < a.GetLength(0); row++)
        {
            for (int col = 0; col < a.GetLength(1); col++)
            {
                Console.Write(a[row, col] + " ");
            }
            Console.WriteLine();
        }
    }
}