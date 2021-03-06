﻿using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Runtime.Caching;
using Inorsoft.Base.Authorization;
using Inorsoft.Base.Caching.Dto;
using Microsoft.Extensions.Caching.Memory;

namespace Inorsoft.Base.Caching
{
    [AbpAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MemoryCacheAppService : PosAppServiceBase, IMemoryCacheAppService
    {
        private readonly IMemoryCache _memoryCache;

        public MemoryCacheAppService(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public void RemoveAllowedDomainsCache()
        {
            Remove(AppConsts.Cache.AllowedDomains.Key);
        }
        public void Remove(string key)
        {
            _memoryCache.Remove(key);
        }
        public bool CheckIfExists(string key)
        {
            return _memoryCache.TryGetValue(key, out var val);
        }
    }
}