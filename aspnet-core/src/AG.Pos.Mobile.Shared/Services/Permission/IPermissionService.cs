namespace AG.Pos.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}