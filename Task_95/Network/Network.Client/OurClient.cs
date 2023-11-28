using System.Net.Sockets;
using System.Net;
using Network.Client.Services;
using Network.Shared;
using System.Text;

namespace Network.Client
{
    public class OurClient : IPrintMessage
    {
        private readonly IGetSend _sendGet = new GetSend();
        private string _ip = string.Empty;
        UdpClient udpClient;
        IPEndPoint iPEndPoint;

        public OurClient(string ip)
        {
            udpClient = new UdpClient();
            iPEndPoint = new IPEndPoint(IPAddress.Parse(ip), 12345);
            _ip = ip;
            HandleCommunication();

        }

        async void HandleCommunication()
        {
            while (true)
            {
                Console.Write("> ");
                string input = Console.ReadLine();
                if (input == null || string.IsNullOrEmpty(input))
                    continue;

                var parts = input.Trim().Split(',', StringSplitOptions.RemoveEmptyEntries);

                if (parts.Length != 3)
                {
                    Console.WriteLine("Неверный формат ввода. Попробуйте снова.");
                    continue;
                }
                if (await SendMessage(parts))
                    await GetMessage();
                else Console.WriteLine("Ошибка отправки сообщения");

            }
        }

        async Task<bool> SendMessage(string[] parts)
        {
            Message message = new Message(parts[0], new UserEntity(parts[1]), new UserEntity(parts[2]));

            var sendMessage = _sendGet.FormingMessageForSend(message).Result;

            if (sendMessage is null)
                return false;

            await udpClient.SendAsync(sendMessage.Data, sendMessage.Data.Length, iPEndPoint);

            return true;
        }

        async Task GetMessage()
        {
            byte[] buffer = udpClient.Receive(ref iPEndPoint);

            var getMessage = await Task.FromResult(_sendGet.FormingMessageForGet(buffer).Result);

            if (getMessage is null)
                Console.WriteLine("Ошибка обработки сообщения.");

            Print(getMessage);

        }

        public void Print(Message message)
        {
            Console.WriteLine($"От {message.NickNameFrom}\n{message.DateTime:F}\n{message.Text}");
        }
    }
}
