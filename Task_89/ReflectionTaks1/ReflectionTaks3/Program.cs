using MyClassLib;
using System.Reflection;
namespace ReflectionTaks3;

class Program
{
    static void Main(string[] args)
    {
        var obj = new MyClass();
        var t = typeof(MyClass);

        FieldInfo? fieldInfo = t.GetField("MyField", BindingFlags.NonPublic | BindingFlags.Instance);

        fieldInfo?.SetValue(obj, 10);

        PropertyInfo? propertyInfo = t.GetProperty("MyProperty", BindingFlags.Public | BindingFlags.Instance);

        var value = (propertyInfo?.GetValue(obj)) as int?;

        Console.WriteLine(value);

    }
}