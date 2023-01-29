using System;

namespace Task_43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите k1: ");
                    var k1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите b1: ");
                    var b1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите k2: ");
                    var k2 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Введите b2: ");
                    var b2 = Convert.ToDouble(Console.ReadLine());

                    if(k1 == k2)
                    {
                        Console.Write("Делить ноль на ноль согласно правилам математики нельзя");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }

                    var x = -(b1 - b2) / (k1 - k2);
                    var y = k1 * x + b1;

                    x = Math.Round(x, 3);
                    y = Math.Round(y, 3);

                    Console.WriteLine($"Пересечение в точке: ({x};{y})");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception)
                {
                    Console.WriteLine($"Ошибка введите число");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
            }
        }
    }
}
