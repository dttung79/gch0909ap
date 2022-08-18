using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankProject
{
    public class BalanceException : Exception
    {
        public BalanceException(string message) : base(message)
        {
        }
    }
}