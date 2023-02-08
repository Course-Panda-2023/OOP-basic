using System.Collections.Generic;
public class Account
{
    private double money;

    public Account(double money)
    {
        this.money = money;
    }
    public Account()
    {
        this.money = 0;
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
    private IDictionary<string, Account> numberNames;
    public double interest;
    private double prevInterest;
    private bool isStartYear;
    public Bank()
    {
        this.numberOfAccount = 0;
        this.numberNames = new Dictionary<string, Account>();
        this.prevInterest = 0;
        this.interest = 0.3;
        this.isStartYear = false;
    }

    public void addAccount(double moneyToAdd, string id)
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
    public void addAccount(string id)
    {
        if (this.numberNames.ContainsKey(id))
        {
            Console.WriteLine("You already have an account");
            return;
        }
        Account account = new Account();
        this.numberNames.Add(id, account);
        this.numberOfAccount++;
    }
    public void addMoney(double moneyToAdd, string id)
    {
        if (!this.isStartYear)
        {
            Console.WriteLine("now not start of the year");
            return;
        }
        if (!this.numberNames.ContainsKey(id))
        {
            Console.WriteLine("You dont have an account");
            return;
        }
        this.numberNames[id].addMoney(moneyToAdd);
        Console.WriteLine("You have successfully added money");
    }
    public void takeMoney(double moneyToTake, string id)
    {
        if (!this.isStartYear)
        {
            Console.WriteLine("now not start of the year");
            return;
        }
        if (!this.numberNames.ContainsKey(id))
        {
            Console.WriteLine("You dont have an account");
            return;
        }
        double t = this.numberNames[id].getSomeMoney(moneyToTake);
        Console.WriteLine($"You have successfully take {t} from Your Account");
    }

    public void deleteAccunt(string id)
    {
        if (!this.isStartYear)
        {
            Console.WriteLine("now not start of the year");
            return;
        }
        if (!this.isStartYear)
        {
            Console.WriteLine("now not start of the year");
            return;
        }
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
        if (!this.isStartYear)
        {
            Console.WriteLine("now not start of the year");
            return;
        }
        this.prevInterest = this.interest;
        Random rnd = new Random();
        double temp = ((double)rnd.Next(-1, 2)) / 100;
        this.interest = Math.Max(this.prevInterest + temp, 0);
    }

    public void addToInterestAccount()
    {
        if (!this.isStartYear)
        {
            Console.WriteLine("now not start of the year");
            return;
        }
        foreach (Account acc in this.numberNames.Values)
        {
            acc.addedInterest(this.interest);
        }
    }
    void setStartOfYear()
    {
        this.isStartYear = true;
    }
    void isNotstartOfYear()
    {
        this.isStartYear = false;
    }
    void inStartOfYear()
    {
        //run this func in start of the year
        setStartOfYear();
        addToInterestAccount();
        updateInterest();
    }
    private string getID()
    {
        Console.WriteLine("enter your ID: ");
        string id = Console.ReadLine();
        return id;
    }

    private int getMoney()
    {
        Console.WriteLine("Enter the amount: ");
        string money = Console.ReadLine();
        int intMoney = Convert.ToInt32(money);
        return intMoney;
    }
    void getDataOfAcc(string id)
    {
        Console.WriteLine(this.numberNames[id].getMoney());
    }
    public void runProgram()
    {

        this.setStartOfYear();
        for (int i = 0; true; i++)
        {
            Console.WriteLine($"the year is {i}");
            Console.WriteLine("Choose what action to take: ");
            Console.WriteLine("1 - Add money to your account");
            Console.WriteLine("2 - Withdraw money from your account");
            Console.WriteLine("3 - Close your account");
            Console.WriteLine("Enter the number that corresponds to the desired action.");
            string coomend = Console.ReadLine();
            int intCoomend = Convert.ToInt32(coomend);
            string id;
            int Money;
            switch (intCoomend)
            {
                case 1:
                    id = this.getID();
                    Money = this.getMoney();
                    this.addMoney(Money, id);
                    break;
                case 2:
                    id = this.getID();
                    Money = this.getMoney();
                    this.takeMoney(Money, id);
                    break;
                case 3:
                    id = this.getID();
                    this.deleteAccunt(id);
                    break;
                default:
                    Console.WriteLine("we move to the next year.");
                    break;
            }
            this.inStartOfYear();
            Console.WriteLine($"The number of accounts in the bank {this.numberOfAccount}");
        }
    }
}
