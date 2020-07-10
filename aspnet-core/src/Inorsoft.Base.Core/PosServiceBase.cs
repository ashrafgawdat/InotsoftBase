using Abp;

namespace Inorsoft.Base
{
    /// <summary>
    /// This class can be used as a base class for services in this application.
    /// It has some useful objects property-injected and has some basic methods most of services may need to.
    /// It's suitable for non domain nor application service classes.
    /// For domain services inherit <see cref="PosDomainServiceBase"/>.
    /// For application services inherit PosAppServiceBase.
    /// </summary>
    public abstract class PosServiceBase : AbpServiceBase
    {
        protected PosServiceBase()
        {
            LocalizationSourceName = PosConsts.LocalizationSourceName;
        }
    }
}