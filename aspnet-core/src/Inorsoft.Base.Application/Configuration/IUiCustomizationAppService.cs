using System.Collections.Generic;
using System.Threading.Tasks;
using Abp.Application.Services;
using Inorsoft.Base.Configuration.Dto;

namespace Inorsoft.Base.Configuration
{
    public interface IUiCustomizationSettingsAppService : IApplicationService
    {
        Task<List<ThemeSettingsDto>> GetUiManagementSettings();

        Task UpdateUiManagementSettings(ThemeSettingsDto settings);

        Task UpdateDefaultUiManagementSettings(ThemeSettingsDto settings);

        Task UseSystemDefaultSettings();
    }
}
