using Abp.Domain.Repositories;
using AG.Pos.MultiTenancy;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AG.Pos.MultiTenancy
{
    public interface IAllowedDomainRepository : IRepository<AllowedDomain>
    {
        void RefreshCache();
        bool HasDomain(string domainName);
        AllowedDomain Find(string domainName);
        IList<AllowedDomain> GetFromCache();
    }
}
