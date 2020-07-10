using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inorsoft.Base.Authorization.Users.Dto;

namespace Inorsoft.Base.Authorization.Users
{
    public interface IUserLoginAppService : IApplicationService
    {
        Task<ListResultDto<UserLoginAttemptDto>> GetRecentUserLoginAttempts();
    }
}
