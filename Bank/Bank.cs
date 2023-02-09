using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP-Basic
{
    public class Bank
    {
        private bool activeAccount = true;
        private double balance;
        private double oriBalance;
        private double currentInterest = 0.03;

        public Bank()
        {
            this.oriBalance = 0;
            this.balance = 0;
            this.CalculateBalance();
            this.simulation();
        }    

        public Bank(double balance)
        {
            this.oriBalance = balance;
            this.balance = balance;
            this.CalculateBalance();
            this.simulation();
        }

        private void CalculateBalance()
        {
            this.balance += this.balance * this.currentInterest;
            this.CalculateInterest();
        }

        private void CalculateInterest()
        {
            Random rnd = new Random();
            double delta = rnd.Next(-1, 3);
            Console.WriteLine($"Delta={delta/100}");
            this.currentInterest = Math.Max(this.currentInterest + delta/100, 0);
            //Console.WriteLine($"cur interrest = {this.currentInterest}");
        }

        private void DepositMoney(double money)
        {
            this.balance += money;
        }

        private void WithdrawMoney(double money)
        {
            this.balance -= money;
        }

        private void CloseAccount()
        {
            this.activeAccount = false;
            Console.WriteLine($"The final balance is: {this.balance}$");
        }

        private void simulation()
        {
            int action;
            Console.WriteLine($"Welcome to our bank!\n" +
                $"Your initial balance is {this.oriBalance}$.\n" +
                $"The yearly interest was 3%.");
            while (this.activeAccount)
            {
                Console.WriteLine($"Your current balance is {this.balance}$.\n" +
                    $"This yealy interest is {this.currentInterest*100}%.\n" +
                    $"Would you like to:\n" +
                    $"1 - Deposit more money?\n" +
                    $"2 - Withdraw some money?\n" +
                    $"3 - Close the account?");
                action = Convert.ToInt32(Console.ReadLine());
                switch (action)
                {
                    case 1:
                        Console.WriteLine("How much money would you like to deposit?");
                        this.DepositMoney(Convert.ToDouble(Console.ReadLine()));
                        this.CalculateBalance();
                        break;
                    case 2:
                        Console.WriteLine("How much money would you like to withdraw?");
                        this.WithdrawMoney(Convert.ToDouble(Console.ReadLine()));
                        this.CalculateBalance();
                        break;
                    case 3:
                        this.activeAccount = false;
                        Console.WriteLine($"\nWe're sorry to hear you want to close the account!\n" +
                                $"Your initial deposit was {this.oriBalance}$.\n" +
                                $"Your final balance in the account was {this.balance}$.");
                        break;
                    default:
                        Console.WriteLine("Please Enter a valid action!");
                        break;
                }
            }
        }
    }

}
