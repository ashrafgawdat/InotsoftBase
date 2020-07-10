namespace Inorsoft.Base.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}