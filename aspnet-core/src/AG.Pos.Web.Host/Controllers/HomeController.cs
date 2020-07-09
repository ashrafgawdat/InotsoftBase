using Abp.Auditing;
using Microsoft.AspNetCore.Mvc;

namespace AG.Pos.Web.Controllers
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
