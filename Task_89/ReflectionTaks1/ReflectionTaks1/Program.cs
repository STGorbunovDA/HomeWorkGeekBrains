using MyClassLib;
using System.Reflection;
namespace ReflectionTaks1;

class Program
{
    static void Main(string[] args)
    {
        var obj = new MyClass();
        var t = typeof(MyClass);

        t.InvokeMember("Say", BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod, null, obj, new Object[] { "Я строка" });
    }
}