using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace Inorsoft.Base.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
