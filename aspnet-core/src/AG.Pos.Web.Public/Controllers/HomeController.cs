using Microsoft.AspNetCore.Mvc;
using AG.Pos.Web.Controllers;

namespace AG.Pos.Web.Public.Controllers
{
    public class HomeController : PosControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}