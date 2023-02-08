using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Bank
{
    private double ribit = 3;
    private List<BankAccount> accounts;
    public List<BankAccount> Accounts
    {
        get { return accounts; }
        set { accounts = value; }
    }
    public Bank()
    {
        this.accounts = new List<BankAccount>();
    }
    public Bank(List<BankAccount> accounts)
    {
        this.accounts = accounts;
    }
    public void AddAccount(BankAccount account)
    {
        this.accounts.Add(account);
    }
    public void RemoveAccount(BankAccount account)
    {
        if (this.accounts.Contains(account))
            this.accounts.Remove(account);
    }
    public void updateRibit()
    {
        Random rnd = new Random();
        int randonNum = rnd.Next(-1, 2);
        this.ribit += randonNum;
        if (ribit > 0)
            ribit = 0;
    }
    public void UpdateAccountsBalanceAfterRibitUpdate()
    {
        foreach (BankAccount account in this.accounts)
        {
            account.Balance *= (1 + ribit / 100);
        }
    }
}