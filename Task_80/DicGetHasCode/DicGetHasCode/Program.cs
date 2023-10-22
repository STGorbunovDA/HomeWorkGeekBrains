using System.Collections;

namespace DicGetHasCode;

class Program
{
    static int[] buckets = new int[10];
    static DictionaryEntry[] entries = new DictionaryEntry[10];
    static int c = 0;

    static void Add(object key, object value)
    {
        int bucketNum = key.GetHashCode() & 0x7fffffff % buckets.Length;
        buckets[bucketNum] = c;
        entries[c].Value = value;
        c++;
    }

    static object Get(object key)
    {
        int bucketNum = key.GetHashCode() & 0x7fffffff % buckets.Length;

        return entries[buckets[bucketNum]].Value;
    }

    static void Main(string[] args)
    {
        Add(5, "Element5");
        Add(6, "Element6");

        Console.WriteLine(Get(5));
        Console.WriteLine(Get(6));
    }
}

