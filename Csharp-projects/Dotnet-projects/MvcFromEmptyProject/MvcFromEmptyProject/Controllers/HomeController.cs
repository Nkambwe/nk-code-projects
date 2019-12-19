using System.Collections.Generic;
using System.Web.Mvc;
using MvcFromEmptyProject.Models;
using MvcFromEmptyProject.ViewModels;

namespace MvcFromEmptyProject.Controllers {

    public class HomeController : Controller {

        public ActionResult Index() {

            //create category object
            var category = new Category {
                Id = 1,
                CatNumber = "C100001",
                CategoryName = "Mineral Water",
                ParentCategory = "Soft Drinks",
                Items = new List<Item>{
                    new Item{Id=1, CatNumber="C100001",ItemNumber="MW00001",ItemName ="Rwenzori"},
                    new Item{Id=2, CatNumber="C100001",ItemNumber="MW00002",ItemName ="Highland"},
                    new Item{Id=3, CatNumber="C100001",ItemNumber="MW00003",ItemName ="Mukwano"},
                    new Item{Id=4, CatNumber="C100001",ItemNumber="MW00004",ItemName ="Britannia"},
                }
            };

            //create view model
            var vmodel = new CategoryViewModel  {
                Category = category,
                Items = category.Items
            };

            return View(vmodel);
        }

    }
}