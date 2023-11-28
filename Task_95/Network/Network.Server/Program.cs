namespace Network.Server
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Выводим приветствие и инструкцию пользователю
            Console.WriteLine("Сервер запущен!");

            OurServer ourServer = new OurServer();
            Console.ReadLine();
        }
    }
}
