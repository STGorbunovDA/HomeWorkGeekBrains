/*
    * Создайте метод, который принимает список строк, функцию (делегат Func) для преобразования строк в числа 
      и действие (делегат Action) для выполнения какого-либо действия с числами.
*/

namespace ConvertStrings;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>() { "1", "2", "3", "4" };

        Parse(list, int.Parse, (x) => Console.WriteLine(x));
    }

    static void Parse(List<string> listStr, Func<string, int> func, Action<int> action)
    {
        foreach (string item in listStr)
        {
            int res = func(item);
            action(res);
        }
    }
}

