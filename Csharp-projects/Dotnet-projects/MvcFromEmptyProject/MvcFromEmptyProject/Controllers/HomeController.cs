using System.Web.Mvc;

namespace MvcFromEmptyProject.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.Title = "Simple MVC App";
            return View();
        }
    }
}