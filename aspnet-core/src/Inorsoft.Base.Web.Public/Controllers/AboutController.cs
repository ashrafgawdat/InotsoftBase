using Microsoft.AspNetCore.Mvc;
using Inorsoft.Base.Web.Controllers;

namespace Inorsoft.Base.Web.Public.Controllers
{
    public class AboutController : PosControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}