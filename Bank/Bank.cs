using System.Collections.Generic;
public class Account
{
    private double money;

    public Account(double money)
    {
        this.money = money;
    }
    public void addMoney(double toAdd)
    {
        this.money += toAdd;
    }
    public double getSomeMoney(double toTake)
    {
        this.money -= toTake;
        return toTake;
    }
    public double getMoney()
    {
        return this.money;
    }
    public void addedInterest(double interest)
    {
        this.money *= (1 + interest);
    }
}

public class Bank
{
    private int numberOfAccount;
    public IDictionary<int, Account> numberNames;
    public double interest;
    double prevInterest;
    public Bank()
    {
        this.numberOfAccount = 0;
        this.numberNames = new Dictionary<int, Account>();
        this.prevInterest = 0;
        this.interest = 0.3;
    }

    public void addAccount(double moneyToAdd, int id)
    {
        if (this.numberNames.ContainsKey(id))
        {
            Console.WriteLine("You already have an account");
            return;
        }
        Account account = new Account(moneyToAdd);
        this.numberNames.Add(id, account);
        this.numberOfAccount++;
    }
    public void addMoney(int id, double moneyToAdd)
    {
        if (!this.numberNames.ContainsKey(id))
        {
            Console.WriteLine("You dont have an account");
            return;
        }
        this.numberNames[id].addMoney(moneyToAdd);
        Console.WriteLine("You have successfully added money");
    }
    public void takeMoney(int id, double moneyToTake)
    {
        if (!this.numberNames.ContainsKey(id))
        {
            Console.WriteLine("You dont have an account");
            return;
        }
        double t = this.numberNames[id].getSomeMoney(moneyToTake);
        Console.WriteLine($"You have successfully take {t} from Your Account");
    }

    public void deleteAccunt(int id)
    {
        if (!this.numberNames.ContainsKey(id))
        {
            Console.WriteLine("You dont have an account");
            return;
        }
        double t = this.numberNames[id].getMoney();
        Console.WriteLine($"left in your account {t}");
        this.numberNames.Remove(id);
        this.numberOfAccount--;
    }
    public void updateInterest()
    {
        this.prevInterest = this.interest;
        Random rnd = new Random();
        double temp = ((double)rnd.Next(-1, 2)) / 100;
        this.interest = Math.Max(this.prevInterest + temp, 0);
    }

    public void addToInterestAccount()
    {
        foreach (Account acc in this.numberNames.Values)
        {
            acc.addedInterest(this.interest);
        }
    }
}
