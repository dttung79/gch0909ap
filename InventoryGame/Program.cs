using System;

namespace InventoryGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            
            player.BuyItem("HP", 10);
            player.BuyItem("MP", 20);
            player.BuyItem("SP", 30);
            
            player.OpenInventory();
            
            player.UseItem("HP");
            
            player.OpenInventory();
        }
    }
}
