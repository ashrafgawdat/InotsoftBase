using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AG.Pos.Caching.Dto;

namespace AG.Pos.Caching
{
    public interface ICachingAppService : IApplicationService
    {
        ListResultDto<CacheDto> GetAllCaches();

        Task ClearCache(EntityDto<string> input);

        Task ClearAllCaches();
    }
}
