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

        
    }
}
