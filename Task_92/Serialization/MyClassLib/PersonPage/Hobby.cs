using System.Xml.Serialization;

namespace MyClassLib.PersonPage
{
    public enum Hobby
    {
        [XmlEnum("Art")]
        Painting,
        [XmlEnum("Hunt")]
        Fishing,
        Sport        
    }
}
