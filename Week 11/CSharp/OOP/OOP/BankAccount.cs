using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    internal class BankAccount
    {
        private string accountName;
        private string accountPassword;
        private double balance;
        private int pinNumber;

        public BankAccount(string name, string password, int pinNumber)
        {
            this.accountName = name;
            this.accountPassword = password;
            this.balance = 0.00;
            this.pinNumber = pinNumber;
        }

        public void SetBalance(double amount)
        {
            this.balance = amount;
        }

        public void Deposit(double amount)
        {
            if (amount >= 0)
            {
                this.balance += amount;
            }
            else
            {
                Console.WriteLine("The amont cannot be negative or equal to zero.");
            }

        }

        public void WithdrawMoney(double amount)
        {
            if (amount > 0 && amount > this.balance)
            {
                this.balance -= amount;
            }
            else
            {
                Console.WriteLine("Cannot withdraw negative amount.");
            }
        }

        public string Represent()
        {
            return $"Account name {this.accountName} has balance: {this.balance}.";
        }

    }
}
