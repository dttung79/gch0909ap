using System;

namespace AutoVendingMachine
{
    class Program
    {
        const int COKE = 1;
        const double COKE_PRICE = 2.00;
        const int WATER = 2;
        const double WATER_PRICE = 1.00;
        const int TEA = 3;
        const double TEA_PRICE = 1.50;
        
        static void Main(string[] args)
        {
            while (true)
            {
                PrintDrinkMenu();
                int choice = GetDrinkChoice();
                int nDrinks = GetNumberOfDrinks();
                double payment = GetPayment(choice, nDrinks);
                Pay(payment);
            }
        }
        static void PrintDrinkMenu()
        {
            Console.WriteLine("1. Coke ($2.00)");
            Console.WriteLine("2. Water ($1.00)");
            Console.WriteLine("3. Tea ($1.50)");
        }
        static int GetDrinkChoice()
        {
            bool invalid = true;
            int choice = 0;
            while (invalid)
            {
                Console.Write("Enter your choice: ");
                choice = int.Parse(Console.ReadLine());
                invalid = choice != 1 && choice != 2 && choice != 3;
                if (invalid) Console.WriteLine("Invalid choice. Please try again.");
            }
            return choice;
        }
        static int GetNumberOfDrinks()
        {
            bool invalid = true;
            int nDrinks = 0;
            while (invalid)
            {
                Console.Write("Enter the number of drinks (1-5): ");
                nDrinks = int.Parse(Console.ReadLine());
                invalid = nDrinks < 1 || nDrinks > 5;
                if (invalid) Console.WriteLine("Invalid number of drinks. Please try again.");
            }
            return nDrinks;
        }
        static double GetPayment(int choice, int nDrinks)
        {
            double payment = 0;
            switch (choice)
            {
                case COKE:
                    payment = COKE_PRICE * nDrinks;
                    break;
                case WATER:
                    payment = WATER_PRICE * nDrinks;
                    break;
                case TEA:
                    payment = TEA_PRICE * nDrinks;
                    break;
            }
            return payment;
        }
        static void Pay(double payment)
        {
            // display payment
            Console.WriteLine("Your payment is: $" + payment);
            bool enough = false;
            while (!enough)
            {
                // insert coin
                int coin = InsertCoin();
                // display change or continue asking for more coins
                double change = coin - payment;
                if (change >= 0)
                {
                    Console.WriteLine("Your change is: $" + change);
                    enough = true;
                }
                else
                {
                    payment = -change;
                    Console.WriteLine("Not enough. Still need $" + payment);
                    Console.WriteLine("Please insert another coin.");
                    
                }
            }
        }
        static int InsertCoin() // valid coin: 1, 2, 5, 10
        {
            bool invalid = true;
            int coin = 0;
            while (invalid)
            {
                Console.Write("Insert a coin: ");
                coin = int.Parse(Console.ReadLine());
                invalid = coin != 1 && coin != 2 && coin != 5 && coin != 10;
                if (invalid) Console.WriteLine("Invalid coin. Please try again.");
            }
            return coin;
        }
    }
}
