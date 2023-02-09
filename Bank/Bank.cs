using System;

public class Bank
{
    private double mBalance;
    private double mInterest = 3;
    private static double mDelta;

    public Bank(double money)
    {
        mBalance = money;
        SetDelta();
        Console.WriteLine("Welcome to the bank! You can deposit and credit money!\n The bank offers a starter interest of 3%, that grows by the following formula! \nmax{interest(n-1)=delta,0}" +
        " and delta is set randomly every year to be between [-1,2]!\n");

    }
    public Bank()
    {
        mBalance = 0;
        SetDelta();
        Console.WriteLine("Welcome to the bank! You can deposit and credit money!\n The bank offers a starter interest of 3%, that grows by the following formula! \nmax{interest(n-1)=delta,0}" +
        " and delta is set randomly every year to be between [-1,2]!\n");
    }
    public void SetDelta()
    {
        double minimum = -1;
        double maximum = 2;
        Random random = new Random();
        mDelta = random.NextDouble() * (maximum - minimum) + minimum;
    }
    public void AddToBalance(double amount)
    {
        mBalance += amount;
    }
    public double GetInterest()
    {
        return mInterest;
    }
    public void SubstructFromBalance(double amount)
    {
        mBalance -= amount;
    }
    public void CloseAccount()
    {
        Console.WriteLine($"Balance is: {mBalance}");
    }
    public void NewYear()
    {
        SetDelta();
        mInterest = Math.Max(mInterest + mDelta, 0);
        mBalance = mBalance * (1 + mInterest * 0.01);
    }

    public double GetBalance()
    {
        return mBalance;
    }
}

