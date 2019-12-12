using Microsoft.AspNetCore.Mvc;

namespace MvcFromEmptyProjectCore.Controllers {

    public class HomeController : Controller {

        public IActionResult Index() {

            ViewBag.Title = "Core MVC";
            return View();
        }
    }
}