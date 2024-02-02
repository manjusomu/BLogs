//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Task
//{
//    public class Account
//    {
//        public string Name { get; set;}
//        public double Balance { get; set;}
//        public Account(string name, double balance) { 
        
        
//        Name = name;
//        Balance = balance;
//        }
//    }
//    public class program1
//    {
        
        
//    static void Main(string[] args)
//        {
//            Account[]accounts=new Account[10];
//            int numAccounts = 0;
//            int choice;


//            do
//            {
//                Console.WriteLine("1: Add a new account");
//                Console.WriteLine("2: Balance Enquiry");
//                Console.WriteLine("3: Withdraw the amount");
//                Console.WriteLine("4: Deposit the amount");
//                Console.WriteLine("5: Exit from the wizard");
//                Console.Write("Enter your choice: ");
//                choice = int.Parse(Console.ReadLine());

//                switch (choice)
//                {
//                    case 1:
//                        {
//                            Console.WriteLine("Adding a new account...");
//                            Console.WriteLine("enter account holder name:");
//                            string name = Console.ReadLine();
//                            Console.WriteLine("Enter intial balance:");
//                            double balance = Convert.ToDouble(Console.ReadLine());
//                            accounts[numAccounts++] = new Account(name, balance);
//                            Console.WriteLine("Account Successfully Added");
//                            break;
//                        }
//                    case 2:
//                        Console.WriteLine("Balance Enquiry...");
//                        Console.WriteLine("enter account holder name:");
//                        string enqname = Console.ReadLine();
//                        bool found = false;
//                        foreach (Account acc in accounts)
//                        {
//                            if (acc != null && acc.Name == enqname)
//                            {
//                                Console.WriteLine($"Balance for {enqname}:{acc.Balance}");
//                                found = true;
//                                break;
//                            }
//                            if (!found)
//                            {
//                                Console.WriteLine("Account not found");
//                            }
//                            break;
//                        }

//                    case 3:
//                        Console.WriteLine("Withdraw the amount...");
//                        Console.WriteLine("Enter account holder name:");
//                        string withdrawName = Console.ReadLine();
//                        Console.WriteLine("Enter amount to withdraw:");
//                        double WithdrawAmount = Convert.ToDouble(Console.ReadLine());
//                        foreach (Account acc in accounts)
//                        {
//                            if (acc != null && acc.Name == withdrawName)
//                            {
//                                if (acc.Balance >= WithdrawAmount)
//                                {
//                                    acc.Balance -= WithdrawAmount;
//                                    Console.WriteLine($"Withdraw Successful. New Balance:{acc.Balance}");
//                                }
//                                else
//                                {
//                                    Console.WriteLine("Insufficient Balance");
//                                }
//                                break;
//                            }
//                        }
//                        break;
//                    case 4:
//                        Console.WriteLine("Deposit the amount...");
//                        Console.WriteLine("Enter account holder name:");
//                        string depositName = Console.ReadLine();
//                        Console.WriteLine("enter amount to deposit");
//                        double depositAmount = Convert.ToDouble(Console.ReadLine());
//                        foreach (Account acc in accounts)
//                        {
//                            if (acc != null && acc.Name == depositName)
//                            {
//                                acc.Balance += depositAmount;
//                                Console.WriteLine($"Deposit successful.New Balance:{acc.Balance}");
//                                break;

//                            }
//                        }
//                        break;
//                    case 5:
//                        Console.WriteLine("Exiting from the wizard...");
//                        break;
//                    default:
//                        Console.WriteLine("Invalid choice. Please enter a valid option.");
//                        break;
//                }
//                Console.WriteLine("Do you want to continue(yes/no)?:");
//                choice = int.Parse(Console.ReadLine());

//            } while (choice.ToString() == "yes");
//        }
//    }

//}

