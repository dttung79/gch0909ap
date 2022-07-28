using System;
using System.Collections.Generic;

namespace ComputerShop
{
    public class Shop
    {
        private List<Product> products;
        public Shop()
        {
            products = new List<Product>();
            products.Add(new Product("Macbook pro M1", 1999, "8GB RAM, 256GB SSD, i7"));
            products.Add(new Product("Alienware M1", 2599, "16GB RAM, 512GB SSD, i5"));
            products.Add(new Product("Surface Pro", 1599, "8GB RAM, 128GB SSD, i5"));
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetUserChoice();
                PrintProduct(choice);
                int numbers = GetProductNumbers();
                PrintBill(choice, numbers);
            }
        }
        public void PrintMenu()
        {
            Console.WriteLine("FPT Shop");
            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine("{0}. {1} - ${2}", i+1, products[i].Name, products[i].Price);
            }
        }
        public void PrintProduct(int choice)
        {
            products[choice-1].PrintInfo();
        }
        public void PrintBill(int choice, int numbers)
        {
            int totalPayment = products[choice - 1].Price * numbers;
            Console.WriteLine("Total payment: ${0}", totalPayment);
        }
        public int GetUserChoice()
        {
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());
            return choice;
        }
        public int GetProductNumbers()
        {
            Console.WriteLine("Enter the number of products: ");
            int numbers = int.Parse(Console.ReadLine());
            return numbers;
        }
    }
}