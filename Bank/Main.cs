using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Console.WriteLine("hello! enter an amount of money to deposit. To open an empty account enter 0");
        double money = 0;
        string input = Console.ReadLine();
        try
        {
            money = Convert.ToDouble(input);
            if (money < 0)
            {
                Console.WriteLine("negetive... creating an empty account");
                money = 0;
            }
        }
        catch
        {
            Console.WriteLine("invalid! creating an empty account!");
        }

        Bank bank = new Bank(money);
        int action = 0;
        do
        {
            Console.WriteLine("enter an action you want to make! to deposit enter 0, to withdraw enter 1, to pass a year press 2,\n to see balance press 3, to see interest of the current year press 4, to stop press -1!");
            action = Convert.ToInt32(Console.ReadLine());
            switch (action)
            {
                case 0:
                    Console.WriteLine("enter amount to deposit");
                    int deposit = Convert.ToInt32(Console.ReadLine());
                    bank.AddToBalance(deposit);
                    break;
                case 1:
                    Console.WriteLine("enter amount to substruct");
                    int substruct = Convert.ToInt32(Console.ReadLine());
                    bank.SubstructFromBalance(substruct);
                    break;
                case 2:
                    bank.NewYear();
                    break;
                case 3:
                    Console.WriteLine($"balance is {bank.GetBalance()}");
                    break;
                case 4:
                    Console.WriteLine($"interest of the year is {bank.GetInterest()}");
                    break;
                case -1:
                    bank.CloseAccount();
                    break;
                default:
                    Console.WriteLine("not valid");
                    break;
            }


        } while (action != -1);
        bank.AddToBalance(0);
        bank.CloseAccount();
    }
}
