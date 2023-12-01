namespace Network.Client.Services.Interfaces
{
    public interface IClientCommunication
    {
        bool SendMessage(string[] parts);
        bool GetMessage();
        void Close();
    }
}
