using System.Collections.Generic;
using MvcFromEmptyProject.Models;

namespace MvcFromEmptyProject.ViewModels {

    public class CategoryViewModel {
        public Category Category { get; set; }
        public List<Item> Items { get; set; }
    }

}