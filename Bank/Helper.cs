using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class Helper
    {
        const string YES = "Y";
        const string NO = "N";
        public static void PrintMenu()
        {
            Console.WriteLine("1. Register Account");
            Console.WriteLine("2. Simulate timeshift for one year");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");            
            Console.WriteLine("5. Print Account");            
            Console.WriteLine("6. Close Account");
            Console.WriteLine("7. Exit");
        }
        
        public static void SimulateMenu(List<BankAccount> accounts)
        {
            BankOperations.UserOperations operation = GetUserValidChoice();
            while (operation != BankOperations.UserOperations.Exit)         
            {                
                switch (operation)
                {
                    case BankOperations.UserOperations.RegisterAccount:
                        RegisterAccount(accounts);
                        break;
                    case BankOperations.UserOperations.SimulateTimeShift:
                        SimulateTimeShift(accounts);
                        break;
                    case BankOperations.UserOperations.Deposit:
                        Deposit(accounts);
                        break;
                    case BankOperations.UserOperations.Withdraw:
                        Withdraw(accounts);
                        break;
                    case BankOperations.UserOperations.PrintAccount:
                        PrintAccount(accounts);
                        break;
                    case BankOperations.UserOperations.CloseAccount:
                        CloseAccount(accounts);
                        return;
                    case BankOperations.UserOperations.Exit:
                        return;
                }
                operation = GetUserValidChoice();
            }
        }
        public static BankOperations.UserOperations GetUserValidChoice()
        {
            BankOperations.UserOperations operation;
            PrintMenu();
            while (true)
            {
                Console.WriteLine("Enter your choice: ");
                string choice = Console.ReadLine();
                if (Enum.TryParse(choice, out operation))
                {
                    return operation - 1;
                }
                Console.WriteLine("Invalid choice");
            }
        }

        public static void PrintAccount(List<BankAccount> accounts)
        {
            Console.WriteLine("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            BankAccount account = FindAccount(accounts, accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }
            Console.WriteLine($"Account Number: {account.AccountNumber}");
            Console.WriteLine($"Name: {account.Name}");
            Console.WriteLine($"Balance: {account.Balance}");
            Console.WriteLine($"ID: {account.ID}");
        }
       
   
        public static BankAccount FindAccount(List<BankAccount> accounts, int accountNumber)
        {
            foreach (var account in accounts)
            {
                if (account.AccountNumber == accountNumber)
                {
                    return account;
                }
            }
            return null;
        }

        public static void SimulateTimeShift(List<BankAccount> accounts)
        {
            foreach (var account in accounts)
            {
                account.ShiftYear();
                account.UpdateInterest();
                account.UpdateBalance();
            }
        }

        public static void Deposit(List<BankAccount> accounts)
        {
            Console.WriteLine("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            BankAccount account = FindAccount(accounts, accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }
            Console.WriteLine("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Deposit(amount);
        }
        public static void Withdraw(List<BankAccount> accounts)
        {
            Console.WriteLine("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            BankAccount account = FindAccount(accounts, accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }
            Console.WriteLine("Enter amount: ");
            double amount = double.Parse(Console.ReadLine());
            account.Withdraw(amount);
        }
        public static void RegisterAccount(List<BankAccount> accounts)
        {
            Console.WriteLine("Enter Account Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your valid ID: ");
            string id = ReadValidID(accounts);
            BankAccount account = new BankAccount(name, id);
            Console.WriteLine("Would you like to deposit an amount into the balance? : ");
            Console.WriteLine("Y/N: ");
            string responce = Console.ReadLine();
            while(responce != YES && responce != NO)
            {
                Console.WriteLine("Invalid responce. Please enter Y or N: ");
                responce = Console.ReadLine();
            }
            if(responce == YES)
            {
                Console.WriteLine("Enter amount: ");
                double amount = double.Parse(Console.ReadLine());
                account.Deposit(amount);
            }
            
            accounts.Add(account);
        }
        
        public static void CloseAccount(List<BankAccount> accounts)
        {
            Console.WriteLine("Enter Account Number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            BankAccount account = FindAccount(accounts, accountNumber);
            if (account == null)
            {
                Console.WriteLine("Account not found");
                return;
            }
            else
            {                
                Console.WriteLine("Are you sure you want to close this account? : ");
                Console.WriteLine("Y/N: ");
                string responce = Console.ReadLine();
                while (responce != YES && responce != NO)
                {
                    Console.WriteLine("Invalid responce. Please enter Y or N: ");
                    responce = Console.ReadLine();
                }
                if (responce == YES)
                {
                    accounts.Remove(account);
                }
                else
                {
                    return;
                }
                
            }            
        }


        /*
         * Checks if ID exists or consist of 9 digits 
         */
        public static string ReadValidID(List<BankAccount> accounts)
        {
            string id = Console.ReadLine();
            while (/*!accounts.Any(a => a.ID == id) ||*/ id.Length != 9 )
            {
                Console.WriteLine("Invalid ID. Please enter a valid ID: ");
                id = Console.ReadLine();
            }
            return id;
        }
    }
}
