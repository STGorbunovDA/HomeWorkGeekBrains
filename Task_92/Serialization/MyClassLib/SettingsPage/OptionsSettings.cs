using System.Xml;
using System.Xml.Serialization;

namespace MyClassLib.SettingsPage
{
    public class OptionsSettings
    {
        public void SaveSettings(Settings s)
        {
            var serializer = new XmlSerializer(s.GetType());

            using (var stream = File.OpenWrite("mySettings.xml"))
            {
                serializer.Serialize(stream, s);
            }

            /* Xml Writer
             
                using(var writer = XmlWriter.Create("mySettings.xml"))
                {
                    serializer.Serialize(writer, s);
                }
            */

        }

        public Settings? LoadSettings()
        {
            string path = "mySettings.xml";
            var serializer = new XmlSerializer(typeof(Settings));

            if (Path.Exists(path))
            {
                using (var stream = File.OpenRead(path))
                {
                    return (Settings?)serializer.Deserialize(stream);
                }

                /* XmlReader
                 
                    using (var reader = XmlReader.Create(path))
                    {
                        return (Settings?)serializer.Deserialize(reader);
                    }
                */
            }
            return null;
        }
    }
}
