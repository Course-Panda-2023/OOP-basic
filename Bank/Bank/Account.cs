using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        private int accountID;
        private User user;
        private float moneyInAccount;
        private bool DidSomethingInAccountThisYear;

        public Account (int accountID, User user, float moneyInAccount)
        {
            this.accountID = accountID;
            this.user = user;
            this.moneyInAccount = moneyInAccount;
            DidSomethingInAccountThisYear = false;
        }
        
        public float GetMoneyInAccount()
        {
            return moneyInAccount;
        }

        public User GetUser()
        {
            return user;
        }

        public void DepositMoney(float amountOfMoney)
        {
            if(!DidSomethingInAccountThisYear)
            {
                moneyInAccount += amountOfMoney;
                DidSomethingInAccountThisYear = true;
            }
        }

        public void PullMoney(float amountOfMoney)
        {
            if (!DidSomethingInAccountThisYear)
            {
                moneyInAccount -= amountOfMoney;
                DidSomethingInAccountThisYear = true;
            }
        }

        public void SetMoneyInAccount(float interest)
        {
            moneyInAccount *= (interest / 100) + 1;
        }

        public void SetDidSomethingInAccountThisYear (bool did)
        {
            DidSomethingInAccountThisYear = did;
        }
    }
}
