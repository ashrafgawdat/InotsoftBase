using System;
using Inorsoft.Base.Core;
using Inorsoft.Base.Core.Dependency;
using Inorsoft.Base.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Inorsoft.Base.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}