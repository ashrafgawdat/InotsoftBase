using System.Threading.Tasks;
using Abp.Application.Services;
using Inorsoft.Base.Configuration.Tenants.Dto;

namespace Inorsoft.Base.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
