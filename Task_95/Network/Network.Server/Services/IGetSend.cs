using Network.Shared.Dtos;
using Network.Shared;

namespace Network.Server.Services
{
    public interface IGetSend
    {
        Task<ServiceResponse<byte[]>> FormingMessageForSend(Message message);

        Task<Message> FormingMessageForGet(byte[] sendMessage);
    }
}
