/*
     * Поиск общих элементов в двух коллекциях
*/

namespace TheFifthLINQTask;

class Program
{
    static void Main(string[] args)
    {
        Repository repository = new Repository();

        var result = repository.hashSet.Intersect(repository.list);

        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
    }
}
