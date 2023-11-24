using MyClassLib.PersonPage;
using System.Xml.Serialization;

public class Program
{
    static void Main()
    {
        var person = new Person()
        {
            Name = "Василий",
            Surname = "Иванов",
            Age = 22,
            Hobbies = new List<Hobby> { Hobby.Fishing, Hobby.Painting, Hobby.Sport},
            Details = new object[]
            {
                new Address {Street = "Строителей", BuildingNo=1},
                new Phone {Home = "+78131118901", Work = "1212s"},
                new Occupation {Company = "Школа №1",Position="Трудовик"}
            }
        };

        var anotherPerson = new AnotherPerson()
        {
            Name = "Петр",
            Surname = "Петров",
            Age = 28,
            Details = new object[]
            {
                new Address {Street = "Мичурина", BuildingNo=3},
                new Phone {Home = "+79016291864", Work = "1313s"},
                new Occupation {Company = "Школа №3",Position="Физик"}
            }
        };

        List<Type> listTypes = new List<Type>();
        foreach (var detail in person.Details)
            listTypes.Add(detail.GetType());
        Type[] types = listTypes.ToArray();


        var serializer = new XmlSerializer(typeof(Group), types);

        var group = new Group { People = new object[] { person, anotherPerson } };

        serializer.Serialize(Console.Out, group);
    }
}