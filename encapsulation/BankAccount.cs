using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace netcore
{
    public class BankAccount
    {
        private decimal balance;

        public BankAccount(decimal balance)
        {
            Deposit(balance);
        }

        public decimal GetBalance()
        {
            return balance;
        }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Deposit must be a posistive!");
            }
            this.balance += amount;
        }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Withdraw must be a posistive!");
            }
            if (amount > balance)
            {
                throw new InvalidOperationException("Insufficient funds!");
            }

            this.balance -= amount;
        }
    }
}