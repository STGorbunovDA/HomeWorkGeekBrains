namespace Network.Client;

internal class Program
{
    static void Main(string[] args)
    {
        // Выводим приветствие и инструкцию пользователю
        Console.WriteLine("Введите через запятую:\nТекст сообщения, Ваш NickName и NickName кому хотите отправить сообщение:");

        OurClient ourClient = new("127.0.0.1");

        Console.ReadLine();
    }
}
