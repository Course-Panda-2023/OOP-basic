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

        public int Id { get { return id; } }
    }
}
