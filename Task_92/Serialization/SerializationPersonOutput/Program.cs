using MyClassLib.PersonPage;
using System.Xml.Serialization;

public class Program
{
    static void Main()
    {
        var str = """
            <XmlPerson xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" IamUnknownAttribute="YouDontKnowMe">
              <Name>Василий</Name>
              <Surname>Иванов</Surname>
              <PatronomicName>Петрович</PatronomicName>
              <Age>22</Age>
              <Details>
                <anyType xsi:type="Address">
                  <Street>Строителей</Street>
                  <BuildingNo>1</BuildingNo>
                </anyType>
                <anyType xsi:type="Phone">
                  <Home>+78131118901</Home>
                  <Work>1212s</Work>
                </anyType>
                <anyType xsi:type="Occupation">
                  <Company>Школа №1</Company>
                  <Position>Трудовик</Position>
                </anyType>
              </Details>
            </XmlPerson>
            """;

        var serializer = new XmlSerializer(typeof(Person));

        var newPerson = (Person?)serializer.Deserialize(new StringReader(str));

        Console.WriteLine(newPerson);


        // если есть элемент или атрибут отсутсвующий в описании класса но присутс. в xml-файле
        if (newPerson != null)
        {
            try
            {
                foreach (var el in newPerson.AllElements)
                    Console.WriteLine($"Неизвестный {el.Name} = {el.InnerText}");

                foreach (var el in newPerson.AllAttributes)
                    Console.WriteLine($"Неизвестный attribute {el.Name} = {el.InnerText}");
            }
            catch
            {
                Console.WriteLine("Ошибка сериализации AllElements или AllAttributes");
            }
            
        }
    }
}