/*
     * В этой задаче у вас есть список строк, и ваша задача – отсортировать этот список 
     * в порядке возрастания длины строк, используя лямбда-выражение. 
     * Ниже приведены начальные данные и возможное решение:
     
        * 
*/


namespace TheThirdLINQTask;

class Program
{
    static void Main(string[] args)
    {
        Repository repository = new Repository();

        var sortedList = repository.strings.OrderBy(s => s.Length).ToList();

        sortedList.ForEach(Console.WriteLine);
    }
}