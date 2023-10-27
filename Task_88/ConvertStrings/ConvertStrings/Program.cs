/*
    1. Создайте метод, который принимает список строк, функцию (делегат Func) для преобразования строк в числа 
       и действие (делегат Action) для выполнения какого-либо действия с числами.

    2. Создайте метод, который принимает список чисел и предикат (делегат Predicate), 
       который определяет, соответствует ли каждое число какому-либо условию.
*/

namespace ConvertStrings;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "1", "2", "3", "4" };
        List<string> listAge = new List<string>() { "18", "21", "13", "14" };

        Parse(list, int.Parse, (x) => Console.WriteLine(x));

        IsAdult(listAge, int.Parse, x => x >= 18, (x) => Console.WriteLine($"Совершеннолетний: {x}"));
    }

    static void Parse(List<string> listStr, Func<string, int> func, Action<int> action)
    {
        foreach (string item in listStr)
        {
            int res = func(item);
            action(res);
        }
    }

    static void IsAdult(List<string> ages, Func<string, int> func, Predicate<int> predicate, Action<int> action)
    {
        foreach (string age in ages)
        {
            int res = func(age);
            if (predicate(res))
                action(res);
        }
    }
}

