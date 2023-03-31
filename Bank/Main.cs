using System;
public class HelloWorld
{
    Random rnd = new Random();
    private double Intrest = 3;
    private double account_balance = 0;
    public static void Main(string[] args)
    {
        var HW = new HelloWorld();
        int year = 1;
        while (true)
        {
            Console.WriteLine("write amount to deposit (negative for withdraw)");
            Console.WriteLine("or type close to shut down account and withdraw entire balance");
            Console.WriteLine("any other input will be ignored");
            Console.WriteLine("current balance: " + HW.account_balance + "NIS");
            Console.WriteLine("year " + year);

            string? userInput = Console.ReadLine();
            if (userInput == "close")
            {
                Console.WriteLine("closing and withdrawing account, withdraw " + HW.account_balance.ToString() + " NIS");
                break;
            }
            if (userInput == null)
                continue;

            try
            {
                int amount_to_deposit = Convert.ToInt32(userInput);
                if (-amount_to_deposit <= HW.account_balance)
                {
                    HW.account_balance += amount_to_deposit;
                    year += 1;
                }
                else
                {
                    Console.WriteLine("can't go into negatives in this savings account");
                    continue;
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("invalid input, restarting cycle, no money will be lost from the balance");
                continue;
            }

            Console.WriteLine("this year's interest is " + HW.Intrest + "% and you earned " + HW.Intrest / 100 * HW.account_balance + "NIS profit");
            HW.account_balance = HW.account_balance * (1 + HW.Intrest / 100);
            HW.calc_new_interest();
        }
    }
    private void calc_new_interest()
    {
        Intrest = Math.Max(Intrest + rnd.Next(-1, 2), 0);
    }
}