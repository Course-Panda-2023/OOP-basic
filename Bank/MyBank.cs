using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class MyBank
    {
        private string name = "bank";
        private int intrest;
        private Dictionary<int, BankAccount> bankAccounts;

        public MyBank() { bankAccounts = new Dictionary<int, BankAccount>(); }

        public void AddBankAccount(BankAccount bankAccount, int id)
        {
            bankAccounts.Add(id, bankAccount);
        }

        public void setName(string name) { this.name = name; }

        public void program()
        {
            Random random = new Random();
            bool exit = false, invalid = false;
            int id;
            double deposit, moneyToDeposit = 0, WithDraw, l = 0.03;
            BankAccount bankAccount;
            string tryId, ans, tryDeposit, tryWithdraw;
            Console.WriteLine($"Hello welcome to {name} \n----------------------");
            Console.WriteLine("Please enter your id (number)");
            tryId = Console.ReadLine();
            while (!int.TryParse(tryId, out id))
            {
                Console.WriteLine("Invalid input\nPlease enter your id (number)");
                tryId = Console.ReadLine();
            }
            Console.WriteLine($"Hello {id}");
            if (!hasAnAccount(id))
            {
                Console.WriteLine("Let create an account\nwould you like to deposit:");
                if (Console.ReadLine() == "y")
                {
                    Console.WriteLine("insert number:");
                    tryDeposit = Console.ReadLine();
                    while (!double.TryParse(tryDeposit, out deposit))
                    {
                        Console.WriteLine("Invalid input\ninsert number:");
                        tryDeposit = Console.ReadLine();
                    }

                    bankAccount = new BankAccount(deposit);
                }
                else
                {
                    bankAccount = new BankAccount();
                }
                AddBankAccount(bankAccount, id);

            }
            while (true)
            {
                Console.WriteLine("Choose an option\n[d] to deposit money\n[w] to withdraw\n[c] for closing the acount");
                ans = Console.ReadLine();
                switch (ans)
                {
                    case "d":
                        Console.WriteLine("How much money to deposit:");
                        tryDeposit = Console.ReadLine();
                        while (!double.TryParse(tryDeposit, out deposit))
                        {
                            Console.WriteLine("Invalid input\ninsert number:");
                            tryDeposit = Console.ReadLine();
                        }
                        bankAccounts[id].deposite(deposit);
                        Console.WriteLine($"deposit successfully\nnow your balance is {bankAccounts[id].Money}");
                        break;

                    case "w":
                        Console.WriteLine("How much money to withdraw:");
                        tryWithdraw = Console.ReadLine();
                        while (!double.TryParse(tryWithdraw, out WithDraw))
                        {
                            Console.WriteLine("Invalid input\ninsert number:");
                            tryWithdraw = Console.ReadLine();
                        }
                        bankAccounts[id].withdraw(WithDraw);
                        Console.WriteLine($"withdraw successfully\nnow your balance is {bankAccounts[id].Money}");
                        break;

                    case "c":
                        exit = true;
                        break;

                    default:
                        invalid = true;
                        break;
                }
                if (invalid) { Console.WriteLine("invalid input\n"); invalid = false; continue; }
                if (exit) { break; }
                bankAccounts[id].NewYear(l + 1);
                l = Math.Max(l + random.NextDouble() * 3 - 1, 0);
                Console.WriteLine($"\n-----------------\nnew yaer!!!!!!!\nhello {id} your balance is {bankAccounts[id].Money}");


            }
            Console.WriteLine("closing!!!!!!!");
        }

        public bool hasAnAccount(int id)
        {
            return bankAccounts.ContainsKey(id);
        }



    }
}
