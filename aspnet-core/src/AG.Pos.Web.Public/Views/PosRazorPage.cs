using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AG.Pos.Web.Public.Views
{
    public abstract class PosRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected PosRazorPage()
        {
            LocalizationSourceName = PosConsts.LocalizationSourceName;
        }
    }
}
