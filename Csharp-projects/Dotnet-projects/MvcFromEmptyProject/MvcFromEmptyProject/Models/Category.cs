using System.Collections.Generic;

namespace MvcFromEmptyProject.Models {
    public class Category {
        public int Id { get; set; }
        public string CatNumber { get; set; }
        public string CategoryName { get; set; }
        public bool IsSubcategory { get; set; }
        public string ParentCategory { get; set; }
        public List<Item> Items { get; set; }

        public override string ToString() => $"{CategoryName}";
    }
}