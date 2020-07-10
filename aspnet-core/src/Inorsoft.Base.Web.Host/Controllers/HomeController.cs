using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace Inorsoft.Base.Web.Controllers
{
    public class HomeController : PosControllerBase
    {
        [DisableAuditing]
        public IActionResult Index()
        {
            return Redirect("/swagger");
        }
    }
}
