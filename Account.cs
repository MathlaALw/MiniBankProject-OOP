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
        // Account number property
        private static int nextAccountNumber = 1; // starting number 
        public int AccountNumber { get; private set; }

        private string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 3)
                    Console.WriteLine("Name must be at least 3 characters.");
                name = value;
            }
        }

        private string nationalId;
        public string NationalId
        {
            get
            {
                return nationalId;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("National ID cannot be null or empty.");
                if (!value.All(char.IsDigit))
                    Console.WriteLine("National ID should contain only digits.");
                if (value.Length != 8)
                    Console.WriteLine("National ID should be exactly 8 digits.");
                nationalId = value;
            }
        }

        private double balance;
        public double Balance
        {
            get
            {
                return balance;

            }
            set
            {
                if (value < 100)
                    Console.WriteLine("Initial balance must be at least 100 OMR.");
                balance = value;
            }
        }

        public string UserType { get; set; }
        public bool IsLocked { get; set; }

        private string phone;
        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 8 || value.Length > 12 || !value.All(char.IsDigit))
                    Console.WriteLine("Phone must be 8-12 digits and numeric.");
                phone = value;
            }
        }

        private string address;
        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    Console.WriteLine("Address cannot be empty.");
                address = value;
            }
        }

        private string HashedPassword;

        public string Password
        {
            get
            {
                return HashedPassword;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 6)
                    Console.WriteLine("Password must be at least 6 characters.");
                HashedPassword = value; // In a real application, you would hash the password here.
            }
        }




        // Constructor
        public Account(string name, string nid, double balance, string userType, string passwordHash, string phone, string address)
        {
            AccountNumber = nextAccountNumber++;
            Name = name;
            NationalId = nid;
            Balance = balance;
            UserType = userType;
            HashedPassword = passwordHash;
            Phone = phone;
            Address = address;
            IsLocked = false;


        }

        


       


    }
}
