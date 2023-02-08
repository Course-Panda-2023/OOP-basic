using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class BankAccount
{
    private double balance;
    public double Balance
    {
        get { return balance; }
        set { balance = value; }
    }
    public BankAccount()
    {
        this.balance = 0;
    }
    public BankAccount(double balance)
    {
        this.balance = balance;
    }
    public void drawMoney(double amount)
    {
        if (amount > this.balance)
            Console.WriteLine("Not enough money in balance");
        else
            this.balance -= amount;
    }
    public void addMoney(double amount)
    {
        this.balance += amount;
    }
    ~BankAccount()
    {
        Console.WriteLine(this.balance);
    }
}