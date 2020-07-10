using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inorsoft.Base
{
    [DependsOn(typeof(PosClientModule), typeof(AbpAutoMapperModule))]
    public class PosXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PosXamarinSharedModule).GetAssembly());
        }
    }
}