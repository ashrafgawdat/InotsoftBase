using System.Threading.Tasks;
using Abp.Application.Services;
using Inorsoft.Base.Install.Dto;

namespace Inorsoft.Base.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}