using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Inorsoft.Base
{
    public class PosClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PosClientModule).GetAssembly());
        }
    }
}
