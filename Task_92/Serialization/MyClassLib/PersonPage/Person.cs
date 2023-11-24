using System.Xml;
using System.Xml.Serialization;

namespace MyClassLib.PersonPage
{
    [XmlType("XmlPerson")]
    public class Person
    {
        public string Name;
        [XmlElement("FamilyName")]
        public string Surname;
        public int Age;
        public object[] Details;

        [XmlArray("HobbyList")]
        [XmlArrayItem("Hobby")]
        public List<Hobby> Hobbies;


        [XmlAnyElement]
        public XmlElement[] AllElements = new XmlElement[] { };

        [XmlAnyAttribute]
        public XmlAttribute[] AllAttributes = new XmlAttribute[] { };

        public override string ToString()
        {
            return $"Name={Name}, Surname={Surname}, Age={Age}";
        }
    }
}
