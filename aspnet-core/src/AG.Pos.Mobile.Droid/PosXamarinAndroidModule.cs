using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AG.Pos
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