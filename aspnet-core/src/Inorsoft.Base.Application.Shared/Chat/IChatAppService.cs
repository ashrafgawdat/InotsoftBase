using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inorsoft.Base.Chat.Dto;

namespace Inorsoft.Base.Chat
{
    public interface IChatAppService : IApplicationService
    {
        GetUserChatFriendsWithSettingsOutput GetUserChatFriendsWithSettings();

        Task<ListResultDto<ChatMessageDto>> GetUserChatMessages(GetUserChatMessagesInput input);

        Task MarkAllUnreadMessagesOfUserAsRead(MarkAllUnreadMessagesOfUserAsReadInput input);
    }
}
