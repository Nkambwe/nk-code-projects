using System.Web.Mvc;
using MvcFromEmptyProject.Models;

namespace MvcFromEmptyProject.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {
            ViewBag.Title = "Inventory Manager";
            var item = new Item{Id =1, ItemName = "Mineral Water"};
            return View(item);
        }

        public ActionResult Edit(int id) {
            return Content($"id={id}");
        }

        public ActionResult Stocking(string category, string batch) {
            category = !string.IsNullOrWhiteSpace(category) ? category : string.Empty;
            batch = !string.IsNullOrWhiteSpace(batch) ? batch : string.Empty;

            return Content($"Category:{category} & Batch:{batch}");
        }

        public ActionResult FilterInventory(int? count, string flag) {
            var issorted = !string.IsNullOrEmpty(flag) && flag.Equals("sort");
            count = count ?? 0;
            flag = issorted ? "sorted" : "not sorted";
            return Content($"Count:{count} & Sort:{flag}");
        }
    }
}