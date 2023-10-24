/*
     * Мы хотим выбрать все строки, содержащие определенную подстроку, 
     * с использованием лямбда-выражения. Вот начальные данные и решение задачи:
     * string searchTerm = "an";
*/

namespace TheFourthLINQTask;

class Program
{
    static void Main(string[] args)
    {
        Repository repository = new Repository();

        repository.words.Where(x => x.Contains("an")).ToList().ForEach(Console.WriteLine);
    }
}


