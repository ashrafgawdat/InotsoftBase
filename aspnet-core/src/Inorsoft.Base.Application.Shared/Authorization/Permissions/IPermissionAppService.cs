using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Inorsoft.Base.Authorization.Permissions.Dto;

namespace Inorsoft.Base.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
