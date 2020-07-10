using System;
using Abp.Dependency;
using Inorsoft.Base.ApiClient;

namespace Inorsoft.Base.Services.Permission
{
    public class PermissionService : IPermissionService, ISingletonDependency
    {
        private readonly IApplicationContext _appContext;

        public PermissionService(IApplicationContext appContext)
        {
            _appContext = appContext;
        }

        public bool HasPermission(string key)
        {
            if (_appContext.Configuration.Auth.GrantedPermissions.TryGetValue(key,
                out var permissionValue))
            {
                return string.Equals(permissionValue, "true", StringComparison.OrdinalIgnoreCase);
            }

            return false;
        }
    }
}