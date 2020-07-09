using System;
using System.Linq;
using Abp.Dependency;
using Abp.Domain.Repositories;
using Abp.Domain.Uow;
using Abp.Extensions;
using Abp.MultiTenancy;
using Abp.Text;
using Abp.Web.MultiTenancy;
using AG.Pos.MultiTenancy;
using Microsoft.AspNetCore.Http;

namespace AG.Pos.Web.TenantResolvers
{
    public class TenantDomainsTenantResolveContributor : ITenantResolveContributor, ITransientDependency
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebMultiTenancyConfiguration _multiTenancyConfiguration;
        private readonly ITenantStore _tenantStore;
        private readonly IRepository<Tenant> _tenantRepository;
        private readonly IUnitOfWorkManager _unitOfWorkManager;

        public TenantDomainsTenantResolveContributor(
            IHttpContextAccessor httpContextAccessor,
            IWebMultiTenancyConfiguration multiTenancyConfiguration,
            ITenantStore tenantStore,
            IRepository<Tenant> tenantRepository,
            IUnitOfWorkManager unitOfWorkManager)
        {
            _httpContextAccessor = httpContextAccessor;
            _multiTenancyConfiguration = multiTenancyConfiguration;
            _tenantStore = tenantStore;
            _tenantRepository = tenantRepository;
            _unitOfWorkManager = unitOfWorkManager;
        }

        public int? ResolveTenantId()
        {
            if (_httpContextAccessor.HttpContext != null)
            {
                var originDomain = _httpContextAccessor.HttpContext.Request.GetCorsOrigin();
                if (!originDomain.IsNullOrWhiteSpace())
                {
                    Uri myUri = new Uri(originDomain);
                    string hostDomain = myUri.Host;
                    var tenant = _tenantRepository.FirstOrDefault(e => e.Domains.Any(d => d.DomainName.Trim().Equals(hostDomain, StringComparison.InvariantCultureIgnoreCase)));
                    if (tenant != null)
                        return tenant.Id;
                }
            }
            return null;
        }
    }
}
