using System;

namespace BankProject
{
    public abstract class Account
    {
        protected static int count = 0;

        protected int id;
        public int ID
        {
            get { return id; }
        }

        public string Name { get; set; }

        protected double balance;
        public double Balance 
        { 
            get { return balance; }
        }

        public void Deposit(double amount)
        {
            CheckPositiveAmount(amount);
            balance += amount;
            Console.WriteLine("Deposit ${0} successfully!", amount);
            // print current balance
            Console.WriteLine("Current balance: ${0}", balance);
        }

        public abstract void Withdraw(double amount);

        public Account(string name)
        {
            Name = name;
            id = ++count;
            balance = 0;
        }

        protected void CheckPositiveAmount(double amount)
        {
            if (amount <= 0) throw new BalanceException("Amount must be positive!");
        }

        protected void CheckEnoughBalance(double amount, double fee, double limit)
        {
            if (balance - amount - fee * amount + limit < 0) 
                throw new BalanceException("Not enough balance!");
        }
    }
}