using Abp.Domain.Uow;
using Abp.EntityFrameworkCore;
using AG.Pos.MultiTenancy;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AG.Pos.EntityFrameworkCore.Repositories
{
    public class AllowedDomainRepository : PosRepositoryBase<AllowedDomain>, IAllowedDomainRepository
    {
        private const string _CACHEKEY = AppConsts.Cache.AllowedDomains.Key;
        private readonly IMemoryCache _memoryCache;

        public AllowedDomainRepository(IDbContextProvider<PosDbContext> dbContextProvider,
            IMemoryCache memoryCache)
            : base(dbContextProvider)
        {
            _memoryCache = memoryCache;
        }

        public void RefreshCache()
        {
            _memoryCache.Remove(_CACHEKEY);
        }

        public bool HasDomain(string domainName)
        {
            return Find(domainName) != null;
        }

        public AllowedDomain Find(string domainName)
        {
            return GetFromCache().FirstOrDefault(e => e.DomainName.Trim().Equals(domainName.Trim(), StringComparison.OrdinalIgnoreCase));
        }

        public IList<AllowedDomain> GetFromCache()
        {
            var domains = _memoryCache.GetOrCreate(_CACHEKEY, (e) =>
            {
                e.AbsoluteExpirationRelativeToNow = TimeSpan.FromSeconds(AppConsts.Cache.AllowedDomains.CacheDurationInSeconds);
                return GetAllowedDomains();
            });

            return domains;
        }

        private IList<AllowedDomain> GetAllowedDomains()
        {
            using (UnitOfWorkManager.Current.DisableFilter(AbpDataFilters.MayHaveTenant))
            {
                return Context.AllowedDomains.Where(e => e.IsActive).ToList();
            }
        }
    }
}
