using MyClassLib.MyClass;
using System.Xml.Serialization;

public class Program
{
    static void Main()
    {
        var serializer = new XmlSerializer(typeof(MyClass));

        var str = """<MyClass xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema"><Field>150</Field><Value>180</Value></MyClass>""";

        var obj = (MyClass?)serializer.Deserialize(new StringReader(str));

        Console.WriteLine(obj);
    }
}