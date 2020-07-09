using System.Threading.Tasks;
using Abp.Application.Services;
using AG.Pos.Configuration.Host.Dto;

namespace AG.Pos.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
