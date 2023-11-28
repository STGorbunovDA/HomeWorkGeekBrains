using Network.Shared;
using Network.Shared.Dtos;

namespace Network.Client.Services
{
    public interface IGetSend
    {
        Task<ServiceResponse<byte[]>> FormingMessageForSend(Message message);

        Task<Message> FormingMessageForGet(byte[] sendMessage);
    }
}
