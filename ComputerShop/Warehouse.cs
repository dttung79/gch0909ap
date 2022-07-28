using System;
using System.Collections.Generic;

namespace ComputerShop
{
    public class Warehouse
    {
        private List<Product> products;
        public List<Product> Products
        {
            get { return products; }
        }

        public Warehouse()
        {
            products = new List<Product>();
        }
        public void Run()
        {
            bool running = true;
            while (running)
            {
                PrintMenu();
                int choice = GetChoice();
                switch (choice)
                {
                    case 1: AddProduct(); break;
                    case 2: EditPrice(); break;
                    case 3: SearchProduct(); break;
                    case 4: running = false; break;
                    default: Console.WriteLine("Invalid choice"); break;
                }
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("Computer Warehouse");
            Console.WriteLine("1. Add product");
            Console.WriteLine("2. Edit price");
            Console.WriteLine("3. Search product");
            Console.WriteLine("4. Exit");
        }
        public int GetChoice()
        {
            Console.Write("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public void AddProduct()
        {
            // enter product name
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            // enter product price
            Console.Write("Enter product price: ");
            int price = int.Parse(Console.ReadLine());
            // enter product configuration
            Console.Write("Enter product configuration: ");
            string configuration = Console.ReadLine();
            // create product object
            //Product p = new Product(name, price, configuration);
            // add product opject to list products
            products.Add(new Product(name, price, configuration));
        }
        public void EditPrice()
        {
            // enter product id
            Console.Write("Enter product id (1-{0}): ", products.Count);
            int id = int.Parse(Console.ReadLine());
            if (id < 1 || id > products.Count)
            {
                Console.WriteLine("Invalid id");
            }
            else
            {
                products[id-1].PrintInfo();
                // enter new price
                Console.Write("Enter new price: ");
                int price = int.Parse(Console.ReadLine());
                // edit price
                products[id - 1].Price = price;
                Console.WriteLine("Price updated successfully");
            }
        }
        public void SearchProduct()
        {
            // ask user to enter product name
            Console.Write("Enter product name: ");
            string name = Console.ReadLine();
            // use for loop search a product with the same name and print its information
            bool found = false;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Name.ToLower().Contains(name.ToLower()))
                {
                    products[i].PrintInfo();
                    found = true;
                }
            }
            if (!found)
            {
                Console.WriteLine("Product {0} not found", name);
            }
        }
    }
}