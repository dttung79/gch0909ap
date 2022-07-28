using System;
using System.Collections.Generic;
namespace ComputerShop
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Warehouse warehouse = new Warehouse();
            Shop shop = new Shop(products);
            while (true)
            {
                Console.Write("Enter account: ");
                string account = Console.ReadLine();
                if (account == "admin")
                {
                    warehouse.Run();
                    products = warehouse.Products;
                }
                else if (account == "user") 
                {
                    shop = new Shop(products);
                    shop.Run();
                }
                else Console.WriteLine("Invalid account");
            }
        }
    }
}
