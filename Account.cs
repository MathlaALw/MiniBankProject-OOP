using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniBankProject_OOP
{
    class Account
    {

        // Properties
        public int AccountNumber { get; private set; }
        public string Name { get; private set; }
        public string NationalId { get; private set; }
        public double Balance { get; private set; }
        public string UserType { get; set; }
        public bool IsLocked { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        private string HashedPassword;

        // Constructor
        public Account(int number, string name, string nid, double balance, string userType, string passwordHash, string phone, string address)
        {
            AccountNumber = number;
            Name = name;
            NationalId = nid;
            Balance = balance;
            UserType = userType;
            HashedPassword = passwordHash;
            Phone = phone;
            Address = address;
            IsLocked = false;
        }

        // Check password method
        public bool CheckPassword(string hashedInput)
        {
            return hashedInput == HashedPassword;
        }


        // Deposit method
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
            else
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
        }


        // Withdraw method
        public bool Withdraw(double amount, double minBalance)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be greater than zero.");
                return false;
            }

            if (Balance - amount >= minBalance)
            {
                Balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Cannot withdraw " + amount + ". Minimum balance of {minBalance} must be maintained.");
                return false;
            }
        }


        // Display Account info method
        public void Display()
        {
            Console.WriteLine("Account Information:");
            Console.WriteLine("Account :" + AccountNumber);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("National ID: " + NationalId);
            Console.WriteLine("Balance: " + Balance.ToString("C2")); // Format as currency
            Console.WriteLine("User Type: " + UserType);
            Console.WriteLine("Phone: " + Phone);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Account Locked: " + (IsLocked ? "Yes" : "No"));


        }



    }
}
