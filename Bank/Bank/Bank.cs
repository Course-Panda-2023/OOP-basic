using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        private string bankName;
        private int bankId;
        private int interest;
        private bool IsNewYear;
        private List<Account> accounts;

        public Bank(string bankName, int bankId, bool IsNewYear)
        {
            this.bankName = bankName;
            this.bankId = bankId;
            this.IsNewYear = IsNewYear;
            accounts = new List<Account>();
            interest = 3;
        }

        public void SetNewYear(bool IsNewYear)
        {
            this.IsNewYear = IsNewYear;
            for (int i = 0; i < accounts.Count; i++)
                accounts[i].SetDidSomethingInAccountThisYear(!IsNewYear);
        }

        public void AddAccount(Account account)
        {
            if(account != null)
            {
                accounts.Add(account);
                if (IsNewYear)
                    account.SetMoneyInAccount(interest);
            }
        }

        public void InterestRate()
        {
            var random = new Random();
            if(IsNewYear)
            {
                int temp = interest + random.Next(-1, 3);
                if (temp > 0)
                    interest = temp;
                else
                    interest = 0;
            }
        }

        public Account GetAccountByUserIDInNewYear (int userID)
        {
            InterestRate();
            if (IsNewYear)
            {
                for(int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].GetUser().GetId() == userID)
                        return accounts[i];
                }
            }
            return null;
        }

        public void DepositMoney(int userID, float amountOfMoney)
        {
            Account a = GetAccountByUserIDInNewYear(userID);
            if(a != null)
            {
                a.DepositMoney(amountOfMoney);
                a.SetMoneyInAccount(interest);
            }
        }

        public void PullMoney(int userID, float amountOfMoney)
        {
            Account a = GetAccountByUserIDInNewYear(userID);
            if(a != null)
            {
                a.PullMoney(amountOfMoney);
                a.SetMoneyInAccount(interest);
            }
        }

        public void CloseAccount(int userID)
        {
            Account a = GetAccountByUserIDInNewYear(userID);
            if(a != null)
            {
                Console.WriteLine($"Account balance: {a.GetMoneyInAccount()}");
                accounts.Remove(a);
            }
        }

        public void PrintAccounts()
        {
            for(int i = 0; i < accounts.Count; i++)
            {
                Console.WriteLine($"User ID: {accounts[i].GetUser().GetId()}");
                Console.WriteLine($"Amount of money in account: {accounts[i].GetMoneyInAccount()}");
                Console.WriteLine();
            }
        }
    }
}
