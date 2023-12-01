using Network.Shared;
using System.Net.Sockets;
using System.Net;
using Network.Client.Services.Interfaces;
using ServicesLib;

namespace Network.Client.Services.Classes
{
    public class ClientCommunication : IClientCommunication
    {
        private readonly UdpClient _udpClient;
        private readonly IGetSend _getSendService;
        private IPEndPoint _iPEndPoint;
        private readonly IPrintMessage _printMessage;

        public ClientCommunication(UdpClient udpClient, IGetSend getSendService, IPrintMessage printMessage)
        {
            _udpClient = udpClient;
            _getSendService = getSendService;
            _printMessage = printMessage;
            _iPEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 12345);
        }

        public bool SendMessage(string[] parts)
        {
            Message message = new Message(parts[0], new UserEntity(parts[1]), new UserEntity(parts[2]));

            var sendMessage = _getSendService.FormingMessageForSend(message).Result;

            if (sendMessage is null)
                return false;

            _udpClient.Send(sendMessage.Data, sendMessage.Data.Length, _iPEndPoint);

            return true;
        }

        public bool GetMessage()
        {
            byte[] buffer = _udpClient.Receive(ref _iPEndPoint);

            var getMessage = _getSendService.FormingMessageForGet(buffer).Result;

            if (getMessage is null)
            {
                Console.WriteLine("Клиент: Ошибка обработки сообщения.");
                return false;
            }

            _printMessage.Print(getMessage);

            if (getMessage.Text.Equals("Сервер остановлен"))
                return false;

            return true;
        }

        public void Close()
        {
            _udpClient.Close();
        }
    }
}
