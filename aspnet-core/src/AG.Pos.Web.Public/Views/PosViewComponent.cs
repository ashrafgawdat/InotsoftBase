using Abp.AspNetCore.Mvc.ViewComponents;

namespace AG.Pos.Web.Public.Views
{
    public abstract class PosViewComponent : AbpViewComponent
    {
        protected PosViewComponent()
        {
            LocalizationSourceName = PosConsts.LocalizationSourceName;
        }
    }
}