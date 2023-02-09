using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    internal class BankModel
    {
        private List<Account> allUsers = new();

        public List<Account> AllUsers
        {
            get { return allUsers; }
            set { allUsers = value; }
        }

        public void AddUser(Account account)
        {
            allUsers.Add(account);
        }

        private void WriteToJsonFileANewAccount()
        {

        }
    }
}
