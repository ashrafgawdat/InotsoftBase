using Microsoft.AspNetCore.Mvc;
using Inorsoft.Base.Web.Controllers;

namespace Inorsoft.Base.Web.Public.Controllers
{
    public class HomeController : PosControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}