using System.Threading.Tasks;
using Abp.Application.Services;
using Inorsoft.Base.Sessions.Dto;

namespace Inorsoft.Base.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
