using MyClassLib;
using System.Reflection;
namespace ReflectionTaks4;

class Program
{
    static void Main(string[] args)
    {
        var obj = Create<MyClass>();
    }

    private static T Create<T>()
    {
        T obj = Activator.CreateInstance<T>();

        if (obj == null)
            throw new Exception("Не удалось создать объект!");

        Type t = obj.GetType();

        var methods = t.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance);

        foreach (var m in methods)
        {
            var attr = m.GetCustomAttributes(false);

            foreach (var a in attr)
                if (a is InvokeAfterCreationAttribute)
                    m.Invoke(obj, new object[] { ((InvokeAfterCreationAttribute)a).X });
        }

        return obj;

    }
}