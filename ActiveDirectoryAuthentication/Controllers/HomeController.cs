using System.Web.Mvc;

namespace ActiveDirectoryAuthentication.Controllers
{
    public class HomeController : Controller
    {
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "NonExistingRole")]
        public ActionResult ForNonExistingRole()
        {
            return View();
        }

        [Authorize(Roles = "Users")]
        public ActionResult OnlyForUsers()
        {
            return View();
        }

        [Authorize]
        public ActionResult MyClaims()
        {
            return View();
        }
    }
}