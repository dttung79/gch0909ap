using System;

namespace BankProject
{
    public class NormalAccount : Account
    {
        private const double fee = 0.01;

        public NormalAccount(string name) : base(name)
        {
        }
        public override void Withdraw(double amount)
        {
            CheckPositiveAmount(amount);
            CheckEnoughBalance(amount, fee, 0);

            balance = balance - amount - fee * amount;
            Console.WriteLine("Withdraw ${0} successfully!", amount);
            Console.WriteLine("Current balance: ${0}", balance);
        }
    }

    public class VIPAccount : Account
    {
        public VIPAccount(string name) : base(name)
        {
        }
        public override void Withdraw(double amount)
        {
            CheckPositiveAmount(amount);
            CheckEnoughBalance(amount, 0, 0);
            
            balance -= amount;
            Console.WriteLine("Withdraw ${0} successfully!", amount);
            Console.WriteLine("Current balance: ${0}", balance);
        }
    }
    public class DebitAccount : Account
    {
        private double limit;
        public double Limit
        {
            get { return limit; }
        }
        public DebitAccount(string name, double limit) : base(name)
        {
            this.limit = limit;
        }
        public override void Withdraw(double amount)
        {
            CheckPositiveAmount(amount);
            CheckEnoughBalance(amount, 0, limit);
            
            balance -= amount;
            Console.WriteLine("Withdraw ${0} successfully!", amount);
            Console.WriteLine("Current balance: ${0}", balance);
        }
    }
}