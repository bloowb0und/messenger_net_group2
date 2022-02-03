using System.Threading.Tasks;
using Core.Models;
using Core.Models.ServiceMethodsModels;

namespace BLL.Abstractions.Interfaces
{
    public interface IChatService
    {
        Task<bool> CreateChatAsync(Chat chat);
        Chat GetChatById(int id);
        Task<bool> DeleteChatAsync(Chat chat);
        Task<bool> EditChatAsync(Chat chat, ChatServiceEditChat newChat);
    }
}