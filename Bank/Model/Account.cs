using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    internal class Account
    {
        private double balance;
        private User user;
        public Account(User user)
        {
            this.user = user;
            balance = 0;
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
}
