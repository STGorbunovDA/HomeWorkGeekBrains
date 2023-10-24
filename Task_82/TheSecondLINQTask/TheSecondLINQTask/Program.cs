/*
     * Отсортировать заказы по сумме в убывающем порядке.
     * Сгруппировать заказы по клиентам и вывести количество заказов для каждого клиента.
     * Найти клиента с наибольшей суммой заказов.
     * Вывести список клиентов и общую сумму их заказов.
     * Попросите студентов использовать LINQ для сортировки и группировки данных.
*/

namespace TheSecondLINQTask;

class Program
{
    static void Main(string[] args)
    {
        Repository repository = new Repository();

        var sum = repository.orders.OrderByDescending(x => x.TotalAmount);
        var sum2 = from order in repository.orders
                   orderby order.TotalAmount
                   select order;

        var totalAmountForClients = repository.orders.GroupBy(x => x.CustomerName).Select(x => new { CustomerName = x.Key, Count = x.Count() });

        var richClient = repository.orders.GroupBy(x => x.CustomerName)
            .Select(x => new { CustomerName = x.Key, SumTotalCount = x.Sum(ta => ta.TotalAmount) })
            .OrderBy(ta => ta.SumTotalCount).Last().CustomerName;

        var clientsTA = repository.orders.GroupBy(x => x.CustomerName)
            .Select(x => new { CustomerName = x.Key, SumTotalCount = x.Sum(ta => ta.TotalAmount) });


        sum.ToList().ForEach(x => Console.WriteLine($"{x.CustomerName} - {x.TotalAmount}"));
        totalAmountForClients.ToList().ForEach(x => Console.WriteLine($"{x.CustomerName} {x.Count} "));
        Console.WriteLine(richClient);
        clientsTA.ToList().ForEach(x => Console.WriteLine($"{x.CustomerName} - {x.SumTotalCount}"));
    }
}