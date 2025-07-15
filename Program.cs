using System.Net;
using System.Numerics;
using System.Text;
using System.Xml.Linq;

namespace MiniBankProject_OOP
{
    internal class Program
    {

        static List<Account> accounts = new List<Account>();



        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("\nMini Bank System Menu");
                Console.WriteLine("1. Create Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. View Balance");
                Console.WriteLine("5. View Transaction History");
                Console.WriteLine("6. Exit");
                Console.Write("Choose an option: ");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1": 
                        CreateAccount(); 
                        break;
                    //case "2":
                    //Deposit();
                    //break;
                    //case "3":
                    //Withdraw();
                    //break;
                    //case "4":
                    //ViewBalance();
                    //break;
                    //case "5":
                    //ShowHistory();
                    //break;
                    case "6": 
                        exit = true; 
                        break;
                    default: 
                        Console.WriteLine("Invalid option."); 
                        break;
                }
            }

        }



        public static void CreateAccount()
        {
            Console.Clear();
            Console.WriteLine("Create New Account");
            try
            {
                bool isValid = true;
                string name;
                do
                {
                    Console.Write("Enter name (min 3 chars): ");
                    name = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(name) || name.Length < 3);

                string nid;
                
                do
                {
                    Console.Write("Enter national ID :");
                    nid = Console.ReadLine();
                    if(string.IsNullOrWhiteSpace(nid))
                    {
                        Console.Write("National ID Can not be null ");
                        isValid = false;
                    }
                     else if (!nid.All(char.IsDigit))
                    {
                        Console.Write("National ID should be digit");
                        isValid = false;
                    }
                    else if (nid.Length != 8)
                    {
                        Console.Write("National ID should be 8 digit");
                        isValid = false;
                    }
                   
                    else
                    {
                        string validNID = nid;
                        isValid = true;
                    }
                }while (!isValid);


                double balance;
                do
                {
                    Console.Write("Enter initial balance (min 100): ");
                } while (!double.TryParse(Console.ReadLine(), out balance) || balance < 100);

                string type;
                do
                {
                    Console.Write("Enter user type (user/admin): ");
                    type = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(type) || (type != "user" && type != "admin"));
                

                string phone;
                do
                {
                    Console.Write("Enter phone (8-12 digits): ");
                    phone = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(phone) || phone.Length < 8 || phone.Length > 12 || !phone.All(char.IsDigit));

                string address;
                do
                {
                    Console.Write("Enter address: ");
                    address = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(address));

                Console.Write("Enter password: ");
                string pass = Console.ReadLine();
                string hashed = Convert.ToBase64String(Encoding.UTF8.GetBytes(pass));
                Account account = new Account(name, nid, balance, type, hashed, phone, address);
                
                accounts.Add(account);
                Console.WriteLine("----------------All Account in Account List------------------------");
                // Display All Acccount from List
                foreach (Account a in accounts)
                {
                    Console.WriteLine("Account Number : " + a.AccountNumber);
                    Console.WriteLine("Owner Name : " + a.Name);
                    Console.WriteLine("National ID : " + a.NationalId);
                    Console.WriteLine("Balance : " + a.Balance);
                    Console.WriteLine("User Type : " + a.UserType);
                    Console.WriteLine("Hashed Password : " + a.Password);
                    Console.WriteLine("Phone : " + a.Phone);
                    Console.WriteLine("Address : " + a.Address);

                }

                Console.WriteLine("Account created successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }


        }



    }
}
