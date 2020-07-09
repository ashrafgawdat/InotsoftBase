using System.Threading.Tasks;
using Abp.Application.Services;
using AG.Pos.Configuration.Tenants.Dto;

namespace AG.Pos.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
