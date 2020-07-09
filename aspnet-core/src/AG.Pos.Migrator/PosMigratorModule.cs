using Abp.AspNetZeroCore;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using AG.Pos.Configuration;
using AG.Pos.EntityFrameworkCore;
using AG.Pos.Migrator.DependencyInjection;

namespace AG.Pos.Migrator
{
    [DependsOn(typeof(PosEntityFrameworkCoreModule))]
    public class PosMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public PosMigratorModule(PosEntityFrameworkCoreModule abpZeroTemplateEntityFrameworkCoreModule)
        {
            abpZeroTemplateEntityFrameworkCoreModule.SkipDbSeed = false;

            _appConfiguration = AppConfigurations.Get(
                typeof(PosMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                PosConsts.ConnectionStringName
                );
            Configuration.Modules.AspNetZero().LicenseCode = _appConfiguration["AbpZeroLicenseCode"];

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PosMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}