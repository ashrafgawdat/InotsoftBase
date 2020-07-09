using Abp.Domain.Services;

namespace AG.Pos
{
    public abstract class PosDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected PosDomainServiceBase()
        {
            LocalizationSourceName = PosConsts.LocalizationSourceName;
        }
    }
}
