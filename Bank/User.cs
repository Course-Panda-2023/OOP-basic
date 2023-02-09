using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Investment
{
    internal class User
    {
        private double accountBalance;
        private string name;
        private int id;
        private String password;
        public User(double accountBalance, String name, int id, String password)
        {
            this.accountBalance = accountBalance;
            this.name = name;
            this.id = id;
            this.password = password;
        }
        public bool checkPassword(String passwordTry)
        {
            return String.Equals(passwordTry, this.password);
        }

        public void addBalance(double money)
        {
            this.accountBalance += money;
            Console.WriteLine("Money deposited");
        }
        public int Id { get { return id; } }
        public double AccountBalance { get { return accountBalance; } }
        public string Name { get { return name; } }
    }
}
