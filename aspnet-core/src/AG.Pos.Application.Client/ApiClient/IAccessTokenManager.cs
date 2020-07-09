using System.Threading.Tasks;
using AG.Pos.ApiClient.Models;

namespace AG.Pos.ApiClient
{
    public interface IAccessTokenManager
    {
        Task<string> GetAccessTokenAsync();
         
        Task<AbpAuthenticateResultModel> LoginAsync();

        void Logout();

        bool IsUserLoggedIn { get; }
    }
}