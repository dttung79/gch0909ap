using System;

namespace ComputerShop
{
    public class Product
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Price { get; set; }
        public string Configuration { get; set; }

        public Product(string name, int price, string configuration)
        {
            this.name = name;
            this.Price = price;
            this.Configuration = configuration;
        }
        public void PrintInfo()
        {
            // print product with 15 spaces, price with 5 spaces
            Console.WriteLine("Product: {0,15}, Price: ${1,5}, Configuration {2, 20}", Name, Price, Configuration);
        }
    }
}