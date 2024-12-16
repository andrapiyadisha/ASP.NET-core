using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a BankAccount class having constructor accepting initialBalance and
//accountHolderName. Also create Deposite() and withdraw() overloaded
//methods by which user can deposit/withdraw amount using different types
//of parameters(ex.cash, check).
namespace Lab_4
{
    internal class BankAccount
    {
        public String Name;
        public double Balance;

        public BankAccount(string Name, double Balance)
        {
            this.Name = Name;
            this.Balance = Balance;
        }

        
        public void Deposit(double cashAmount)
        {
            if (cashAmount > 0)
            {
                Balance += cashAmount;
                Console.WriteLine(cashAmount + " in cash And New Balance is " +Balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Deposit(string checkNumber, double checkAmount)
        {
            if (checkAmount > 0)
            {
                Balance += checkAmount;
                Console.WriteLine(checkAmount + " in cash And New Balance is " + Balance);
            }
            else
            {
                Console.WriteLine("Invalid deposit amount.");
            }
        }

        public void Withdraw(double cashAmount)
        {
            if (cashAmount > 0 && cashAmount <= Balance)
            {
                Balance -= cashAmount;
                Console.WriteLine(cashAmount + " in cash AND New Balance is " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
            }
        }

        public void Withdraw(string checkNumber, double checkAmount)
        {
            if (checkAmount > 0 && checkAmount <= Balance)
            {
                Balance -= checkAmount;
                Console.WriteLine(checkAmount + " in cash AND New Balance is " + Balance);
            }
            else
            {
                Console.WriteLine("Insufficient balance or invalid withdrawal amount.");
            }
        }

        public void DisplayAccountDetails()
        {
            Console.WriteLine("Account Holder: "+ Name);
            Console.WriteLine("Current Balance: "+ Balance);
        }
    }
}
