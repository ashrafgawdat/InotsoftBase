using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Inorsoft.Base.Authorization;

namespace Inorsoft.Base
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(PosCoreModule)
        )]
    public class PosApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PosApplicationModule).GetAssembly());
        }
    }
}