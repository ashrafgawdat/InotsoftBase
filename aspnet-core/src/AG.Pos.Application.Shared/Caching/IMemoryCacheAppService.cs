using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AG.Pos.Caching.Dto;

namespace AG.Pos.Caching
{
    public interface IMemoryCacheAppService : IApplicationService
    {
        void RemoveAllowedDomainsCache();
        void Remove(string key);
        bool CheckIfExists(string key);
    }
}
