using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        private double money;

        public double Money { get { return money; } }
        public BankAccount(double money)
        {
            this.money = money;
        }

        public BankAccount()
        {
            money = 0;
        }

        public double deposite(double amount)
        {
            money += amount;
            return money;
        }
        public double withdraw(double amount)
        {
            money -= amount;
            return money;
        }

        public void NewYear(double year)
        {
            money *= year;
        }
    }
}
