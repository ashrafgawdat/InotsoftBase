using System.Threading.Tasks;
using Abp.Application.Services;
using AG.Pos.Install.Dto;

namespace AG.Pos.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}