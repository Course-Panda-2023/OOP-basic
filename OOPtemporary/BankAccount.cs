using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPtemporary
{
    public class BankAccount
    {
        private static int customerCounter = 0;
        private static double intrest = BankAccount.CalcNewIntrest();

        public BankAccount(string customerName, double balance)
        {
            this.CustomerId = customerCounter;
            customerCounter++;
            this.CustomerName = customerName;
            this.Balance = balance;
        }

        public BankAccount(string customerName)
        {
            this.CustomerId = customerCounter;
            customerCounter++;
            this.CustomerName = customerName;
            this.Balance = 0;
        }



        ~BankAccount()
        {
            Console.WriteLine($"your account is closed with balance of: {this.Balance}$");
        }

        private int CustomerId { get; }
        private string CustomerName { get;}
        private double Balance { get; set; }

        private void Deposit(double amount)
        {
            this.Balance += amount;
            this.Balance = Math.Round(this.Balance, 2);
        }

        private void Withdraw(double amount)
        {
            if (amount > this.Balance)
            {
                Console.WriteLine("Warning, you are going into debt.");
            }
            this.Balance -= amount;
            this.Balance = Math.Round(this.Balance, 2);
        }
        private void ApplyIntrest()
        {
            this.Balance *= (BankAccount.intrest+100) / 100;
            this.Balance = Math.Round(this.Balance, 2);

        }

        public static double CalcNewIntrest()
        {
            double ribitDelta = MathHelper.GetDoubleWithinRange(-1,2);
            return Math.Round(Math.Max(intrest + ribitDelta,0),2);
        }

        public static void RunSimulation()
        {
            int input = 0;
            Console.WriteLine("Welcome to the best bank in the world!");
            Console.WriteLine("Please enter your name to open an account.");
            BankAccount b1 = new BankAccount(Console.ReadLine());

            while (input != 3) {
                Console.WriteLine("deposit money press 1");
                Console.WriteLine("withdraw money press 2");
                Console.WriteLine("close account press 3");
                input = int.Parse(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        Console.WriteLine("enter amount to deposit");
                        string amountToDepositStr = Console.ReadLine();
                        double amountToDeposit = Convert.ToDouble(amountToDepositStr);
                        b1.Deposit(amountToDeposit);
                        break;
                    case 2:
                        Console.WriteLine("enter amount to withdraw");
                        string amountToWithdrawStr = Console.ReadLine();
                        double amountToWithdraw = Convert.ToDouble(amountToWithdrawStr);
                        b1.Withdraw(amountToWithdraw);
                        break;
                }
                Console.WriteLine();
                Console.WriteLine("year passed");
                b1.ApplyIntrest();
                Console.WriteLine($"last year's intrest was: {BankAccount.intrest}");
                BankAccount.intrest = BankAccount.CalcNewIntrest();
                Console.WriteLine($"new intrest: {BankAccount.intrest}");
                Console.WriteLine($"money you currently have: {b1.Balance}");
            }
            Console.WriteLine($"money you had left: {b1.Balance}");
        }
    }
}
