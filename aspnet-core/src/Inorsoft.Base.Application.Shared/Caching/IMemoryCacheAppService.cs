using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inorsoft.Base.Caching.Dto;

namespace Inorsoft.Base.Caching
{
    public interface IMemoryCacheAppService : IApplicationService
    {
        void RemoveAllowedDomainsCache();
        void Remove(string key);
        bool CheckIfExists(string key);
    }
}
