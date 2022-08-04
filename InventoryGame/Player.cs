using System;

namespace InventoryGame
{
    public class Player
    {
        private Inventory inventory;
        public Player()
        {
            inventory = new Inventory();
        }
        public void BuyItem(string name, int value)
        {
            Item item = new Item(name, value);
            inventory.AddItem(item);
        }
        public void OpenInventory()
        {
            foreach (Item item in inventory.Items)
            {
                Console.WriteLine("{0} - {1} gold", item.Name, item.Value);
            }
        }
        public void UseItem(string name)
        {
            Item item = inventory.SearchItem(name);
            if (item != null)
            {
                item.Use();
                inventory.RemoveItem(name);
            }
        }
    }
}