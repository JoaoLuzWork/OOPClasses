using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPClass3
{
    class Account
    {
        private decimal balance;
        public decimal Balance
        {
            get { return balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Balance cannot be negative.");
                }
                balance = value;
            }
        }
        public Account(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public bool Credit(decimal amount)
        {
            if (amount < 0)
            {
                return false; // Credit amount cannot be negative
            }
            
            Balance += amount;
            return true;
        }

        public bool Debit(decimal amount)
        {
            if (amount < 0)
            {
                return false; // Debit amount cannot be negative
            }
            if (amount > Balance)
            {
                return false; // Insufficient funds
            }
            Balance -= amount;
            return true;

        }
    }
}
        