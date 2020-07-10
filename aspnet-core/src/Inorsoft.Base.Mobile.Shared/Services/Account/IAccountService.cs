using System.Threading.Tasks;
using Inorsoft.Base.ApiClient.Models;

namespace Inorsoft.Base.Services.Account
{
    public interface IAccountService
    {
        AbpAuthenticateModel AbpAuthenticateModel { get; set; }
        AbpAuthenticateResultModel AuthenticateResultModel { get; set; }
        Task LoginUserAsync();
    }
}
