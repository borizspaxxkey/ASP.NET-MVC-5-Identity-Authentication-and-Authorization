using Identity.ViewModels;
using System.Web.Mvc;

namespace Identity.Controllers
{
    //  [Authorize(Roles = "Administrators,Managers")]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            var VM = new MyViewModel();
            VM.IsAdmin = false;

            return View(VM);
        }

        [Authorize(Roles = "Admin")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";
            var VM = new MyViewModel();
            VM.IsAdmin = true;

            return View(VM);
        }
    }
}