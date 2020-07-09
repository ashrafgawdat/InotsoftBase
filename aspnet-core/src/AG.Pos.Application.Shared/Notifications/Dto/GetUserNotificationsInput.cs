using Abp.Notifications;
using AG.Pos.Dto;

namespace AG.Pos.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}