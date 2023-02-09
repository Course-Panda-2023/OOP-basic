using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class User
    {
        private int id;
        private string name;
        private string email;
        private string password;

        public User (int id , string name, string email, string password)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.password = password;
        }

        public int GetId() { return id; }
    }
}
