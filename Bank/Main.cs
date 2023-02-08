using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class EX2Main
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount(5000);
        List<BankAccount> accounts = new List<BankAccount>();
        accounts.Add(account);
        Bank bank = new Bank(accounts);
        int year = 2023;
        while (year != -1)
        {
            Console.WriteLine("Choose: ");
            Console.WriteLine("1) Draw Money");
            Console.WriteLine("2) Add Money");
            Console.WriteLine("3) Close Account");
            Console.WriteLine("4) My Balance");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter amount of money to draw");
                    int money_draw = Convert.ToInt32(Console.ReadLine());
                    bank.Accounts[0].drawMoney(money_draw);
                    break;
                case 2:
                    Console.WriteLine("Enter amount of money to add");
                    int money_add = Convert.ToInt32(Console.ReadLine());
                    bank.Accounts[0].addMoney(money_add);
                    break;
                case 3:
                    year = -1;
                    Console.WriteLine("Account Closed");
                    break;
                case 4:
                    Console.WriteLine(bank.Accounts[0].Balance);
                    break;
                default:
                    break;
            }
            bank.updateRibit();
            bank.UpdateAccountsBalanceAfterRibitUpdate();
        }
    }
}