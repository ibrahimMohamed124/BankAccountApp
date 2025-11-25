using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccountApp
{
    internal class BankAccount
    {
        public string Owner { get; set; }
        public Guid AccountNumber { get; set; }
        public decimal Balance { get; private set; }

        public BankAccount(string owner)
        {
            Owner = owner;
            AccountNumber = Guid.NewGuid();  // Generate a new unique account number
            Balance = 0; // Initial balance is 0
        }

        public string Deposit(decimal amount)
        {
            if (amount <= 0)
                return "Deposit amount must be positive.";
            
            if (amount > 20000) 
                return "Deposit amount exceeds the maximum limit of $20,000.";
            
            Balance += amount;
            return $"Successfully deposited {amount:C}. New balance is {Balance:C}.";
        }

        public string Withdraw(decimal amount)
        {
            if (amount <= 0)
                return "Withdraw amount must be positive.";
            if (amount > Balance)
                return "You Don't have enough money.";

            Balance -= amount;
            return $"Successfully withdrawn {amount:C}. New balance is {Balance:C}.";
        }

    }
}
