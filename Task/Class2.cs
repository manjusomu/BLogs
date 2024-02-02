using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    public class Account
    {
        public string Name { get; set; }
        public double Balance { get; set; }

        public Account(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }
  public   class Program2
    {
        static void Main(string[] args)
        {
            // Assuming you have some kind of account class
            // Account[] accounts = new Account[MAX_ACCOUNTS];
            Account[] accounts = new Account[10]; // Example array of accounts
            int numAccounts = 0;

            string choice;
            do
            {
                Console.WriteLine("1: Add a new account");
                Console.WriteLine("2: Balance Enquiry");
                Console.WriteLine("3: Withdraw the amount");
                Console.WriteLine("4: Deposit the amount");
                Console.WriteLine("5: Exit from the wizard");
                Console.Write("Enter your choice: ");
                int option = Convert.ToInt32(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("Adding a new account...");
                        Console.Write("Enter account holder's name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter initial balance: ");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        accounts[numAccounts++] = new Account(name, balance);
                        Console.WriteLine("Account added successfully!");
                        break;
                    case 2:
                        Console.WriteLine("Balance Enquiry...");
                        Console.Write("Enter account holder's name: ");
                        string enqName = Console.ReadLine();
                        bool found = false;
                        foreach (Account acc in accounts)
                        {
                            if (acc != null && acc.Name == enqName)
                            {
                                Console.WriteLine($"Balance for {enqName}: {acc.Balance}");
                                found = true;
                                break;
                            }
                        }
                        if (!found)
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Withdraw the amount...");
                        Console.Write("Enter account holder's name: ");
                        string withdrawName = Console.ReadLine();
                        Console.Write("Enter amount to withdraw: ");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        foreach (Account acc in accounts)
                        {
                            if (acc != null && acc.Name == withdrawName)
                            {
                                if (acc.Balance >= withdrawAmount)
                                {
                                    acc.Balance -= withdrawAmount;
                                    Console.WriteLine($"Withdrawal successful. New balance: {acc.Balance}");
                                }
                                else
                                {
                                    Console.WriteLine("Insufficient balance.");
                                }
                                break;
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine("Deposit the amount...");
                        Console.Write("Enter account holder's name: ");
                        string depositName = Console.ReadLine();
                        Console.Write("Enter amount to deposit: ");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());
                        foreach (Account acc in accounts)
                        {
                            if (acc != null && acc.Name == depositName)
                            {
                                acc.Balance += depositAmount;
                                Console.WriteLine($"Deposit successful. New balance: {acc.Balance}");
                                break;
                            }
                        }
                        break;
                    case 5:
                        Console.WriteLine("Exiting from the wizard...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a valid option.");
                        break;
                }
                Console.WriteLine("Do you want to continue(yes/no)?:");
                choice = Console.ReadLine();

            } while (choice.ToLower() == "yes");
        }
    }

 

}
