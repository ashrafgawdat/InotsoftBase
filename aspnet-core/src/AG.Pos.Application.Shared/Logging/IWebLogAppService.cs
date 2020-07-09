using Abp.Application.Services;
using AG.Pos.Dto;
using AG.Pos.Logging.Dto;

namespace AG.Pos.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
