/*
 * Задача 1: Фильтрация и проекция данных с использованием LINQ
   Предоставьте студентам некоторую коллекцию объектов (например, список студентов) и попросите их решить следующие задачи:

   * Найти всех студентов, чей возраст меньше 25 лет.
   * Вывести имена всех студентов в алфавитном порядке.
   * Выбрать студентов, обучающихся на факультете инженерии.
   * Посчитать средний возраст студентов.
   * Попросите студентов использовать LINQ для решения этих задач.
*/

namespace OneTaskLINQ;

class Program
{
    static void Main(string[] args)
    {
        Repository repository = new Repository();

        var findAge = repository.students.Where(x => x.Age < 25);
        var sortName = repository.students.OrderBy(x => x.Name).Select(x => x.Name);
        var findEngeners = repository.students.Where(x => x.Faculty.Equals("Engineering"));
        var averageEge = repository.students.Average(x => x.Age);

        findAge.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Age}"));
        sortName.ToList().ForEach(x => Console.WriteLine($"{x}, "));
        findEngeners.ToList().ForEach(x => Console.WriteLine($"{x.Name} - {x.Faculty}"));
        Console.WriteLine(averageEge);
    }
}
