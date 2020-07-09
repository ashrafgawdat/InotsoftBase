using System;
using System.Linq;
using Abp.Dependency;
using Abp.Extensions;
using Abp.MultiTenancy;
using Abp.Web.MultiTenancy;
using AG.Pos.MultiTenancy;
using Microsoft.AspNetCore.Http;

namespace AG.Pos.Web.MultiTenancy
{
    public class TenantDomainsTenantResolveContributor : ITenantResolveContributor, ITransientDependency
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebMultiTenancyConfiguration _multiTenancyConfiguration;
        private readonly IAllowedDomainRepository _allowedDomainRepository;

        public TenantDomainsTenantResolveContributor(
            IHttpContextAccessor httpContextAccessor,
            IWebMultiTenancyConfiguration multiTenancyConfiguration,
            IAllowedDomainRepository allowedDomainRepository)
        {
            _httpContextAccessor = httpContextAccessor;
            _multiTenancyConfiguration = multiTenancyConfiguration;
            _allowedDomainRepository = allowedDomainRepository;
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
                    var domain = _allowedDomainRepository.Find(hostDomain);
                    if (domain != null)
                        return domain.TenantId;
                }
            }
            return null;
        }
    }
}
