using System;
using System.Collections.Generic;

namespace BankProject
{
    public class BankProgram : MenuProgram
    {
        private List<Account> accounts;

        public BankProgram()
        {
            accounts = new List<Account>();
        }

        protected override void PrintMenu()
        {
            Console.WriteLine("1. Add normal account.");
            Console.WriteLine("2. Add VIP account.");
            Console.WriteLine("3. Add debit account.");
            Console.WriteLine("4. Search account.");
            Console.WriteLine("5. Deposit.");
            Console.WriteLine("6. Withdraw.");
        }

        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: AddNormalAccount(); break;
                case 2: AddVIPAccount();    break;
                case 3: AddDebitAccount();  break;
                case 4: SearchAccount();    break;
                case 5: Deposit();          break;
                case 6: Withdraw();         break;
                case 0: break;
                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
        private void AddNormalAccount()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            NormalAccount acc = new NormalAccount(name);
            accounts.Add(acc);
            Console.WriteLine("Add normal account successfully!");
        }
        private void AddVIPAccount()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            VIPAccount acc = new VIPAccount(name);
            accounts.Add(acc);
            Console.WriteLine("Add VIP account successfully!");
        }
        private void AddDebitAccount()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter limit: ");
            double limit = double.Parse(Console.ReadLine()); // Use GetDouble to avoid FormatException
            DebitAccount acc = new DebitAccount(name, limit);
            accounts.Add(acc);
            Console.WriteLine("Add debit account successfully!");
        }

        private void SearchAccount()
        {
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine();
            bool found = false;
            foreach (Account acc in accounts)
            {
                if (acc.Name.Contains(name))
                {
                    Console.WriteLine("ID: {0}, name: {1}, balance: ${2}", acc.ID, acc.Name, acc.Balance);
                    found = true;
                }
            }
            if (!found) Console.WriteLine("No account for name {0}", name);
        }
        private void Deposit()
        {
            Account acc = FindAccByEnteredID();
            if (acc == null)
            {
                Console.WriteLine("Account not found!");
                return;
            }
            ChangeBalance(acc, "deposit");
        }
        private void Withdraw()
        {
            Account acc = FindAccByEnteredID();
            if (acc == null) 
            {
                Console.WriteLine("Account not found!");
                return;
            }
            ChangeBalance(acc, "withdraw");
        }
        private void ChangeBalance(Account acc, string change)
        {
            bool validAmount = false;
            while (!validAmount)
            {
                try 
                {
                    Console.WriteLine("Enter amount: ");
                    double amount = double.Parse(Console.ReadLine()); 
                    if (change == "withdraw") acc.Withdraw(amount);
                    else acc.Deposit(amount);
                    validAmount = true;
                }
                catch (BalanceException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        private Account FindAccByEnteredID()
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine()); 

            foreach (Account acc in accounts)
            {
                if (acc.ID == id) return acc;
            }
            return null;
        }
    }
}