using Abp.Application.Services;
using Abp.Application.Services.Dto;
using AG.Pos.Authorization.Permissions.Dto;

namespace AG.Pos.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
