using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inorsoft.Base
{
    [DependsOn(typeof(PosXamarinSharedModule))]
    public class PosXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PosXamarinIosModule).GetAssembly());
        }
    }
}