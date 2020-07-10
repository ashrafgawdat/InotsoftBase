using Abp.Application.Services;
using Inorsoft.Base.Dto;
using Inorsoft.Base.Logging.Dto;

namespace Inorsoft.Base.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
