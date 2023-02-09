using Bank.Model;
using Bank.Utils;
using Bank.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controller
{
    internal class SystemClass
    {
        private BankModel bankModel;

        private BankGUI bankGUI;

        private int serialNumber = 0;
        private double l = 1.03;

        public SystemClass(BankModel _bankModel, BankGUI _bankGUI)
        {
            bankModel = _bankModel;
            bankGUI = _bankGUI;
        }

        private void UpdateWithInterest()
        {
            Span<Account> accounts = CollectionsMarshal.AsSpan(bankModel.AllUsers);
            Random random = new Random();
            this.l = Math.Max(this.l + random.NextDouble() * 3 - 1, 0);
            Func<double, double> interests = (x) => this.l * x;
            for (int i = 0; i < accounts.Length; ++i)
            {
                accounts[i].Balance = interests(accounts[i].Balance);
            }
        }
        public void Invoke()
        {
            bankGUI.Welcome();
            bool isAlive = true;
            do
            {
                string name = bankGUI.OpenNewAccount();
                Account account = new Account(new User(name, serialNumber.ToString()));
                ++serialNumber;
                bankModel.AddUser(account);
                Console.WriteLine("Account is Added successfully!!!");
                Console.WriteLine();

                Console.WriteLine("****************************Instructions********************************");
                bool alive = true;
                
                do
                {
                    bankGUI.OperationsInstruction();
                    char operation = bankGUI.InputAnOperation();
                    Console.WriteLine();
                    switch (operation)
                    {
                        case 'D':
                            Console.WriteLine("Enter a desposit amount");
                            double desposit = bankGUI.Deposit();
                            account.Balance += desposit;
                            break;
                        case 'W':
                            Console.WriteLine("Enter a withdraw amount");
                            double withdraw = bankGUI.Withdraw();
                            account.Balance -= withdraw;
                            break;
                        case 'C':
                            bankGUI.CloseAccount(account.Balance);
                            alive = false;
                            break;
                    }

                    Console.WriteLine();
                    UpdateWithInterest();
                    
                } while (alive);
            } while (isAlive);
             

        }
    }
}
