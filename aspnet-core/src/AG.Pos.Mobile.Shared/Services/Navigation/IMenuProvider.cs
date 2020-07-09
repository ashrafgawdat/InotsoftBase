using System.Collections.Generic;
using MvvmHelpers;
using AG.Pos.Models.NavigationMenu;

namespace AG.Pos.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}