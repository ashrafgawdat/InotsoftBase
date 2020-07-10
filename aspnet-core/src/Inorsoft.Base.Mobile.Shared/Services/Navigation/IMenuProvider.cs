using System.Collections.Generic;
using MvvmHelpers;
using Inorsoft.Base.Models.NavigationMenu;

namespace Inorsoft.Base.Services.Navigation
{
    public interface IMenuProvider
    {
        ObservableRangeCollection<NavigationMenuItem> GetAuthorizedMenuItems(Dictionary<string, string> grantedPermissions);
    }
}