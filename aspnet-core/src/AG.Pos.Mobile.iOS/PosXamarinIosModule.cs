using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AG.Pos
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