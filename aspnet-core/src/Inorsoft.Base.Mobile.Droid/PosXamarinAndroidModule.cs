using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inorsoft.Base
{
    [DependsOn(typeof(PosXamarinSharedModule))]
    public class PosXamarinAndroidModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PosXamarinAndroidModule).GetAssembly());
        }
    }
}