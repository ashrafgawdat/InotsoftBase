using System.Threading.Tasks;
using Abp.Application.Services;
using AG.Pos.Sessions.Dto;

namespace AG.Pos.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
