using System.Collections.Generic;
using AG.Pos.Authorization.Permissions.Dto;

namespace AG.Pos.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}