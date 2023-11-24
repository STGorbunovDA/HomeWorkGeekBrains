using System.Xml.Serialization;

namespace MyClassLib.PersonPage
{
    public class Group
    {
        [XmlElement(typeof(Person))]
        [XmlElement(typeof(AnotherPerson))]
        public object[] People;
    }
}
