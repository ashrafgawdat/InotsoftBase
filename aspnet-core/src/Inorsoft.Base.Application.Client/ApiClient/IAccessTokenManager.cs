using System.Threading.Tasks;
using Inorsoft.Base.ApiClient.Models;

namespace Inorsoft.Base.ApiClient
{
    public interface IAccessTokenManager
    {
        Task<string> GetAccessTokenAsync();
         
        Task<AbpAuthenticateResultModel> LoginAsync();

        void Logout();

        bool IsUserLoggedIn { get; }
    }
}