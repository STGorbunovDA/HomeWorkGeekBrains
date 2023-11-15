namespace MyClassLib
{
    public class MyClass
    {
        int MyField = 3;
        public int MyProperty => MyField * -1;

        public void SayHello() => Console.WriteLine("Hello");
        public void Say(string s) => Console.WriteLine($"{s}");

        [InvokeAfterCreation("Я создан с помощью рефлексии!")]
        private void SomeMethod(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}