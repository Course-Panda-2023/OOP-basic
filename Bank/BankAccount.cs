using System;

class BankAccount
{
    private double balance;
    private bool isOpen;
    private int year;
    public BankAccount()
    {
        this.balance = 0;
        this.isOpen = true;
    }
    public BankAccount(double ammount)
    {
        this.balance = ammount;
        this.isOpen = true;
    }

    public bool GetIsOpen()
    {
        return this.isOpen;
    }
    private double CalculateInterest(int y)
    {
        if (y == 0)
        {
            return 0.03;
        }
        else
        {
            Random ran = new Random();
            return Math.Max(CalculateInterest(y - 1) + (ran.NextDouble() * 3 - 1) / 100, 0);
        }
    }
    public void PassYear()
    {
        year++;
        balance += 100 * CalculateInterest(year);
    }
    public void AddAmount(double amount)
    {
        balance += amount;
    }

    public void whithdrawMoney(double amount)
    {
        if (balance - amount > 0)
        {
            balance -= amount;
        }
        else
        {
            Console.WriteLine("You don't have enough money left :(");
        }
    }
    public void closeAccount()
    {
        Console.WriteLine(balance);
        isOpen = false;
    }
}

