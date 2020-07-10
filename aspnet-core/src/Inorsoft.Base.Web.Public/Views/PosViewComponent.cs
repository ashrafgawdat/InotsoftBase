using Abp.AspNetCore.Mvc.ViewComponents;

namespace Inorsoft.Base.Web.Public.Views
{
    public abstract class PosViewComponent : AbpViewComponent
    {
        protected PosViewComponent()
        {
            LocalizationSourceName = PosConsts.LocalizationSourceName;
        }
    }
}