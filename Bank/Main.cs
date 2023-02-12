using System;


public class BankMain
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Open an account homie.");
        Console.WriteLine("Enter amount to insert money or press enter to not at the moment");
        InvestAccount account;
        try
        {
            account = new InvestAccount(Convert.ToDouble(Console.ReadLine()));
        }
        catch (System.FormatException)
        {
            account = new InvestAccount();
        }
            
        bool finished = false;
        while (!finished)
        {
            Console.WriteLine($"Current interest is: {account.interest}");
            Console.WriteLine($"Yo current money is: {account.money}");
            
            Console.WriteLine("Would you like to deposit, withdraw or do nothing? Enter 'Deposit'/'Withdraw'/anything else accordingly");
            string desicion = Console.ReadLine();
            switch (desicion)
            {
                case "Deposit":
                    Console.WriteLine("Enter amount to deposit");
                    account.DepositMoney(Convert.ToDouble(Console.ReadLine()));
                    break;
                case "Withdraw":
                    Console.WriteLine("Enter amount to withdraw");
                    account.WithdrawMoney(Convert.ToDouble(Console.ReadLine()));
                    break;
                default:
                    break;
            }
            Console.WriteLine("Are you finished? (yes/no)");
            if (Console.ReadLine() != "no")
                finished = true;
            account.YearlyUpdate();
        }
        Console.WriteLine($"Final amount in account is {account.money}");
    }
}
