using MyClassLib.MyClass;
using System.Xml.Serialization;

public class Program
{
    static void Main()
    {
        var serializer = new XmlSerializer(typeof(MyClass), "MyNameSpace");

        serializer.Serialize(Console.Out, new MyClass());
    }
}