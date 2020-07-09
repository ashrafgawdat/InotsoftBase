using Abp.Authorization;
using AG.Pos.Authorization.Roles;
using AG.Pos.Authorization.Users;

namespace AG.Pos.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
