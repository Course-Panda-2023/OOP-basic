using System;

public class Bank
{
    private double balance;
    private double interest = 3;
    private static double delta;

    public Bank(double money)
    {
        balance = money;
        SetDelta();
        Console.WriteLine("Welcome to the bank! You can deposit and credit money!\n The bank offers a starter interest of 3%, that grows by the following formula! \nmax{interest(n-1)=delta,0}" +
        " and delta is set randomly every year to be between [-1,2]!\n");

    }
    public Bank()
    {
        balance = 0;
        SetDelta();
        Console.WriteLine("Welcome to the bank! You can deposit and credit money!\n The bank offers a starter interest of 3%, that grows by the following formula! \nmax{interest(n-1)=delta,0}" +
        " and delta is set randomly every year to be between [-1,2]!\n");
    }
    public void SetDelta()
    {
        double minimum = -1;
        double maximum = 2;
        Random random = new Random();
        delta = random.NextDouble() * (maximum - minimum) + minimum;
    }
    public void AddToBalance(double amount)
    {
        balance += amount;
    }
    public double GetInterest()
    {
        return interest;
    }
    public void SubstructFromBalance(double amount)
    {
        balance -= amount;
    }
    public void CloseAccount()
    {
        Console.WriteLine($"Balance is: {balance}");
    }
    public void NewYear()
    {
        SetDelta();
        interest = Math.Max(interest + delta, 0);
        balance = balance * (1 + interest * 0.01);
    }

    public double GetBalance()
    {
        return balance;
    }
}

