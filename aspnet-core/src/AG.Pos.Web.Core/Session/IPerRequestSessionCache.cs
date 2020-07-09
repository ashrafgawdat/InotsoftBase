using System.Threading.Tasks;
using AG.Pos.Sessions.Dto;

namespace AG.Pos.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
