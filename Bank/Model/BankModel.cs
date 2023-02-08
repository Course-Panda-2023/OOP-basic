using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Model
{
    internal class BankModel
    {
        List<Account> allUsers = new();

        public void AddUser(Account account)
        {
            allUsers.Add(account);
        }

        private void WriteToJsonFileANewAccount()
        {

        }
    }
}
