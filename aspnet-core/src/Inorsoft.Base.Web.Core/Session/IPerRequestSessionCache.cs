using System.Threading.Tasks;
using Inorsoft.Base.Sessions.Dto;

namespace Inorsoft.Base.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
