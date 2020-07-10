using System.Collections.Generic;
using Inorsoft.Base.Authorization.Permissions.Dto;

namespace Inorsoft.Base.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}