using Abp.Domain.Services;

namespace Inorsoft.Base
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
