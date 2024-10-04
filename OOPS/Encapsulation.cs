//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OOPS
//{
//    class BankAccount
//    {
//        // Private fields - encapsulated data
//        private string accountHolder;
//        private double balance;

//        // Constructor to initialize the account holder and balance
//        public BankAccount(string holder, double initialBalance)
//        {
//            accountHolder = holder;
//            balance = initialBalance;
//        }

//        // Public method to get the balance (controlled access)
//        public double GetBalance()
//        {
//            return balance;
//        }

//        // Public method to deposit money (controlled access)
//        public void Deposit(double amount)
//        {
//            if (amount > 0)
//            {
//                balance += amount;
//                Console.WriteLine($"Deposited {amount}. New balance is {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Deposit amount must be positive.");
//            }
//        }

//        // Public method to withdraw money (controlled access)
//        public void Withdraw(double amount)
//        {
//            if (amount > 0 && amount <= balance)
//            {
//                balance -= amount;
//                Console.WriteLine($"Withdrew {amount}. New balance is {balance}");
//            }
//            else
//            {
//                Console.WriteLine("Invalid withdrawal amount.");
//            }
//        }
//    }

//    class Encapsulation
//    {
//        static void Main()
//        {
//            BankAccount account = new BankAccount("Vaibhav Koli", 500.0);

//            account.Deposit(150.0);   // Deposit money
//            account.Withdraw(200.0);  // Withdraw money

//            Console.WriteLine($"Account Balance: {account.GetBalance()}");  // Controlled access
//        }
//    }
//}
