using System;

namespace InventoryGame
{
    public class Item
    {
        public string Name { get; set; }
        public int Value { get; set; }
        // default constructor
        public Item()
        {
            Name = "HP";
            Value = 10;
        }
        // constructor with parameters
        public Item(string name, int value)
        {
            Name = name;
            Value = value;
        }

        public void Use()
        {
            Console.WriteLine("You used {0} and cost {1} gold", Name, Value);
        }
    }
}