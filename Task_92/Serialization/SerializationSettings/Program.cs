using MyClassLib.SettingsPage;
using System.Xml;

public class Program
{
    static void Main()
    {
        
        OptionsSettings optionsSettings = new OptionsSettings();

        var settings = optionsSettings.LoadSettings();

        if(settings == null)
        {
            Console.WriteLine("Новые настройки...");
            settings = new Settings { Setting1 = "On", Setting2 = "Off", Setting3 = "1.25" };
        }
        else Console.WriteLine("Старые настройки...");

        Console.WriteLine(settings);

        settings.Setting1 = "Off";
        settings.Setting2 = "On";
        settings.Setting3 = "0.001";

        optionsSettings.SaveSettings(settings);

        var set = new XmlWriterSettings
        {
            Indent = true,
            IndentChars = "    "
        };

        
        /* XmlReader
         
            using(var reader = XmlReader.Create("mySettings.xml"))
            {
                while (reader.Read())
                {
                    if(reader.IsStartElement()) //<tag>
                    {
                        Console.Write("<");
                        Console.Write(reader.Name);
                        Console.WriteLine(">");
                    }
                    else
                    {
                        if(reader.NodeType == XmlNodeType.EndElement) //</tag>
                        {
                            Console.Write("</");
                            Console.Write(reader.Name);
                            Console.WriteLine(">");
                        }
                        else Console.WriteLine(reader.Value); //<tag> Значение</tag>
                    }
                }
            }
        */



    }
}