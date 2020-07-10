using Abp.AspNetCore.Mvc.Authorization;
using Inorsoft.Base.Storage;

namespace Inorsoft.Base.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(ITempFileCacheManager tempFileCacheManager) :
            base(tempFileCacheManager)
        {
        }
    }
}