
using System.Collections.Generic;
using System.Linq;

namespace MvcFromEmptyProject.Models {
    public class Item {
        public int Id { get; set; }
        public string CatNumber { get; set; }
        public string ItemNumber { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }

        public override string ToString() => $"{ItemNumber}::{ItemName}";
    }

    public class Items {
        private readonly List<Item> _itemlist = new List<Item>();

        public void AddItem(Item item) {
            if(item != null && !_itemlist.Contains(item))
                _itemlist.Add(item);
        }

        public void Remove(Item item) {
            if(_itemlist.Contains(item))
                _itemlist.Remove(item);
        }

        public void Remove(int id) {
            var item = new Item();
            var olditem = _itemlist.FirstOrDefault(i => i.Id == id);
            if (olditem != null && !_itemlist.Contains(olditem))
                _itemlist.Remove(item);
        }

        public Item GetItem(int id) {
            return _itemlist.FirstOrDefault(i => i.Id == id);
        }

        public List<Item> GetAll() {
            return _itemlist;
        }
    }
}