using System;
using System.Text.RegularExpressions;

namespace HomeWork_Task_21
{
    internal class Program
    {
        static double Distance(double x1, double y1, double z1, double x2, double y2, double z2)
        {
            double dist = Math.Pow((Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2) * 1.0), 0.5);
            return dist;
        }
        static void Main(string[] args)
        {
            double x1, y1, z1, x2, y2, z2;
            while (true)
            {
                Console.WriteLine("Введите координаты первой точки в 3D пространстве (x1, y1, z1)! Пример: 3,6,8:");
                string coordinatesFirstPoint = Console.ReadLine();
                //int number;
                while (true)
                {
                    if (Regex.IsMatch(coordinatesFirstPoint, @"^[-]?[0-9]{1,1}[,][-]?[0-9]{1,1}[,][-]?[0-9]{1,1}$"))
                    {
                        Regex re = new Regex(@"^([-]?[0-9]{1,1})[,]([-]?[0-9]{1,1})[,]([-]?[0-9]{1,1})$");
                        Match result = re.Match(coordinatesFirstPoint);

                        x1 = Convert.ToDouble(result.Groups[1].Value);
                        y1 = Convert.ToDouble(result.Groups[2].Value);
                        z1 = Convert.ToDouble(result.Groups[3].Value);

                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Ошибка! Введите корректно координаты первой точки в 3D пространстве (x1, y1, z1) Пример: -3,6,8(без пробелов):");
                    coordinatesFirstPoint = Console.ReadLine().Trim();
                    Console.Clear();
                }
                Console.WriteLine("Введите координаты второй точки в 3D пространстве (x2, y2, z2)! Пример: 2,1,-7:");
                string coordinatesTwoPoint = Console.ReadLine();

                while (true)
                {
                    if (Regex.IsMatch(coordinatesTwoPoint, @"^[-]?[0-9]{1,1}[,][-]?[0-9]{1,1}[,][-]?[0-9]{1,1}$"))
                    {
                        Regex re = new Regex(@"^([-]?[0-9]{1,1})[,]([-]?[0-9]{1,1})[,]([-]?[0-9]{1,1})$");
                        Match result = re.Match(coordinatesTwoPoint);

                        x2 = Convert.ToDouble(result.Groups[1].Value);
                        y2 = Convert.ToDouble(result.Groups[2].Value);
                        z2 = Convert.ToDouble(result.Groups[3].Value);

                        Console.Clear();
                        break;
                    }
                    Console.WriteLine("Ошибка! Введите корректно координаты второй точки в 3D пространстве (x1, y1, z1)\n Пример: 2,1,-7(без пробелов):");
                    coordinatesTwoPoint = Console.ReadLine().Trim();
                    Console.Clear();
                }
                Console.WriteLine($"Расстояние между точками в 3D пространстве: {Distance(x1, y1, z1, x2, y2, z2)}");

                Console.ReadKey();
                Console.Clear();
            }

        }
    }
}
