using System;
using System.Collections.Generic;

namespace InventoryGame
{
    public class Inventory
    {
        private List<Item> items;
        public List<Item> Items
        {
            get { return items; }
        }
        public Inventory()
        {
            items = new List<Item>();
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public Item SearchItem(string name)
        {
            foreach (Item item in items)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }
        public void RemoveItem(string name)
        {
            Item item = SearchItem(name);
            if (item != null)
            {
                items.Remove(item);
            }
        }
    }
}