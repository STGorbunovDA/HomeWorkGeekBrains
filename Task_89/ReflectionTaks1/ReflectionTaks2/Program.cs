using MyClassLib;
using System.Reflection;
namespace ReflectionTaks2;

class Program
{
    static void Main(string[] args)
    {
        var obj = new MyClass();
        var t = typeof(MyClass);

        FieldInfo? fieldInfo = t.GetField("MyField", BindingFlags.NonPublic | BindingFlags.Instance);

        var value = (fieldInfo?.GetValue(obj)) as int?;

        Console.WriteLine(value);

    }
}