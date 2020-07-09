using System;
using System.Threading.Tasks;
using Abp;
using Abp.Notifications;
using AG.Pos.Authorization.Users;
using AG.Pos.MultiTenancy;

namespace AG.Pos.Notifications
{
    public interface IAppNotifier
    {
        Task WelcomeToTheApplicationAsync(User user);

        Task NewUserRegisteredAsync(User user);

        Task NewTenantRegisteredAsync(Tenant tenant);

        Task GdprDataPrepared(UserIdentifier user, Guid binaryObjectId);

        Task SendMessageAsync(UserIdentifier user, string message, NotificationSeverity severity = NotificationSeverity.Info);
    }
}
