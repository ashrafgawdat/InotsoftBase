using Abp.Domain.Repositories;
using Inorsoft.Base.MultiTenancy;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Inorsoft.Base.MultiTenancy
{
    public interface IAllowedDomainRepository : IRepository<AllowedDomain>
    {
        void RefreshCache();
        bool HasDomain(string domainName);
        AllowedDomain Find(string domainName);
        IList<AllowedDomain> GetFromCache();
    }
}
