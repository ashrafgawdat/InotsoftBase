using Abp.Notifications;
using Inorsoft.Base.Dto;

namespace Inorsoft.Base.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}