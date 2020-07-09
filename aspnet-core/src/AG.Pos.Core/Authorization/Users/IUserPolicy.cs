using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace AG.Pos.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
