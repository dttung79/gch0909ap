using System;

namespace MovieTickets
{
    class Program
    {
        const int ADULT_PRICE = 2;
        const int CHILD_PRICE = 1;
        static void Main(string[] args)
        {
            while (true)
            {
                PrintMovies();
                string movie = ChooseMovie();
                int nAdultTickets = GetNumberOfTickets("adult");
                int nChildTickets = GetNumberOfTickets("children");
                int payment = GetBill(movie, nAdultTickets, nChildTickets);
                Pay(payment, movie);
            }
        }
        static void PrintMovies()
        {
            Console.WriteLine("1. The Matrix");
            Console.WriteLine("2. Star Wars");
            Console.WriteLine("3. The Godfather");
        }
        static string ChooseMovie()
        {
            bool invalid = true;
            string movie = "";
            while (invalid)
            {
                Console.Write("Enter your choice: ");
                int choice = Console.ReadLine();
                invalid = choice != "1" && choice != "2" && choice != "3";
                if (invalid) Console.WriteLine("Invalid choice. Please try again.");
            }
            switch (choice)
            {
                case "1":
                    movie = "The Matrix";
                    break;
                case "2":
                    movie = "Star Wars";
                    break;
                case "3":
                    movie = "The Godfather";
                    break;
            }
            return movie;
        }
        static int GetNumberOfTickets(string ticketType)
        {
            bool invalid = true;
            int nTickets = 0;
            while (invalid)
            {
                Console.Write("Enter the number of " + ticketType + " tickets: ");
                nTickets = int.Parse(Console.ReadLine());
                invalid = nTickets < 1;
                if (invalid) Console.WriteLine("Invalid number of tickets. Please try again.");
            }
            return nTickets;
        }
        static int GetBill(string movie, int nAdultTickets, int nChildTickets)
        {
            int bill = nAdultTickets * ADULT_PRICE + nChildTickets * CHILD_PRICE;
            Console.WriteLine("Your Bill:");
            Console.WriteLine("Movie: " + movie);
            Console.WriteLine("Adult Tickets: " + nAdultTickets * ADULT_PRICE);
            Console.WriteLine("Child Tickets: " + nChildTickets * CHILD_PRICE);
            Console.WriteLine("Total: " + bill);
            return bill;
        }
        static void Pay(int payment, string movie)
        {
            Console.WriteLine("Your payment is: $" + payment);
            bool notEnough = true;
            while (notEnough)
            {
                Console.Write("Enter your money: ");
                int money = int.Parse(Console.ReadLine());
                if (money >= payment)
                {
                    Console.WriteLine("Your change is: $" + (money - payment));
                    notEnough = false;
                }
                else
                {
                    payment = payment - money;
                    Console.WriteLine("Not enough. Still need $" + payment);
                }
            }
            Console.WriteLine("Thank you for choosing " + movie + "!");
        }
    }
}
