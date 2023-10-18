using SearchIsCapital;
using System.Threading.Channels;

var sx = new List<string> { "AaAaA", "AAAAA", "aaa", "BBBBB" };
var ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var x = sx.FindIndex(Capital.IsCapital);

if (x>=0)
{
    Console.WriteLine(x);
    x++;
}

while (x>=0 && x< sx.Count)
{
    x = sx.FindIndex(x, Capital.IsCapital);

    if (x >= 0)
    {
        Console.WriteLine(x);
        x++;
    }
}

var res = ints.RemoveAll(x => x % 2 == 0);

Console.WriteLine($"Чётных чисел: {res}");

ints.ForEach(Console.WriteLine);

Console.ReadLine();