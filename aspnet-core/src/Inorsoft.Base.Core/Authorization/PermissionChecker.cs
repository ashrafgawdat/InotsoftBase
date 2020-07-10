using Abp.Authorization;
using Inorsoft.Base.Authorization.Roles;
using Inorsoft.Base.Authorization.Users;

namespace Inorsoft.Base.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
