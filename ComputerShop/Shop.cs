using System;
using System.Collections.Generic;

namespace ComputerShop
{
    public class Shop
    {
        private List<Product> products;
        public Shop(List<Product> products)
        {
            this.products = products;
        }

        public void Run()
        {
            while (true)
            {
                PrintMenu();
                int choice = GetUserChoice();
                if (choice == 0) break;
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