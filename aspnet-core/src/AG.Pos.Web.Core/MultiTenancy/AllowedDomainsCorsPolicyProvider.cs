using AG.Pos.MultiTenancy;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace AG.Pos.Web.MultiTenancy
{
    public class AllowedDomainsCorsPolicyProvider : ICorsPolicyProvider
    {
        private static readonly Task<CorsPolicy> _notfound = Task.FromResult<CorsPolicy>(null);
        private readonly Task<CorsPolicy> _policy;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IAllowedDomainRepository _allowedDomainRepository;

        public AllowedDomainsCorsPolicyProvider(IHostingEnvironment hostingEnvironment, IAllowedDomainRepository allowedDomainRepository)
        {
            var builder = new CorsPolicyBuilder();
            builder.SetIsOriginAllowed(IsOriginAllowed);
            builder.AllowAnyHeader();
            builder.AllowAnyMethod();
            builder.AllowCredentials();

            _policy = Task.FromResult(builder.Build());

            _hostingEnvironment = hostingEnvironment;
            _allowedDomainRepository = allowedDomainRepository;
        }

        private bool IsOriginAllowed(string origin)
        {
            if (origin == null)
            {
                return false;
            }
            origin = origin.ToLowerInvariant();

            var dev = _hostingEnvironment.IsDevelopment();
            if (dev)
            {
                if (origin.StartsWith("http://localhost:") || origin.StartsWith("https://localhost:"))
                {
                    return true;
                }
            }
            Uri myUri = new Uri(origin);
            string hostDomain = myUri.Host;

            return _allowedDomainRepository.HasDomain(hostDomain);
        }

        public Task<CorsPolicy> GetPolicyAsync(HttpContext context, string policyName)
        {
            if (policyName == AppConsts.AllowedDomainsCorsPolicyName)
            {
                return _policy;
            }
            return _notfound;
        }
    }
}
