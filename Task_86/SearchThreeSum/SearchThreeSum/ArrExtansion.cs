namespace SearchThreeSum
{
    public static class ArrExtansion
    {
        public static IEnumerable<string> FindThreeNumbers(this int[] nums, int targetSum)
        {
            List<string> result = new();

            // Сортируем массив, чтобы легче выполнять поиск
            Array.Sort(nums);

            int length = nums.Length;

            // Итерируем по элементам массива, за исключением последних двух элементов
            for (int i = 0; i < length - 2; i++)
            {
                // Задаем начальные значения указателей для поиска трех чисел
                int left = i + 1;
                int right = length - 1;

                // Получаем текущее число для проверки тройки чисел
                int currentNum = nums[i];

                // Ищем тройки чисел, пока указатели не встретятся
                while (left < right)
                {
                    // Вычисляем текущую сумму трех чисел
                    int currentSum = currentNum + nums[left] + nums[right];

                    // Проверяем, равна ли текущая сумма целевой сумме
                    if (currentSum == targetSum)
                    {
                        // Если равна, выводим найденную тройку чисел
                        result.Add($"Тройка чисел: {currentNum}, {nums[left]}, {nums[right]}");
                        left++;
                        right--;
                    }
                    else if (currentSum < targetSum)
                    {
                        // Если текущая сумма меньше целевой суммы, увеличиваем левый указатель
                        left++;
                    }
                    else
                    {
                        // Если текущая сумма больше целевой суммы, уменьшаем правый указатель
                        right--;
                    }
                }
            }
            return result;
        }
    }
}
