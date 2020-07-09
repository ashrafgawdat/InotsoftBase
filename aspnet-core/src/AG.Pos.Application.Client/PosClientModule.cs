using Abp.Modules;
using Abp.Reflection.Extensions;

namespace AG.Pos
{
    public class PosClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(PosClientModule).GetAssembly());
        }
    }
}
