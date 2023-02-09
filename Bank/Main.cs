using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        const int FINISH = -1;

        Console.WriteLine("Enter 0 for new empty account or an amount for new account with amount");
        int answer = Convert.ToInt32(Console.ReadLine());
        BankAccount account;

        if (answer == 0)
        {
            account = new BankAccount();
        }
        else
        {
            account = new BankAccount(answer);
        }

        while (answer != FINISH)
        {
            Console.WriteLine("Enter 1 to pass year, 2 to deposit money, 3 to take money out, 4 to close account, -1 to exit");
            answer = Convert.ToInt32(Console.ReadLine());

            switch (answer)
            {
                case 1:
                    account.PassYear();
                    break;

                case 2:
                    Console.WriteLine("Enter ammount to deposit: ");
                    int ammount = Convert.ToInt32(Console.ReadLine());
                    account.AddAmount(ammount);
                    break;

                case 3:
                    Console.WriteLine("Enter ammount to take out: ");
                    ammount = Convert.ToInt32(Console.ReadLine());
                    account.whithdrawMoney(ammount);
                    break;

                case 4:
                    account.closeAccount();
                    Console.WriteLine("Enter 0 for new empty account or an amount for new account with amount");
                    answer = Convert.ToInt32(Console.ReadLine());
                    if (answer == 0)
                    {
                        account = new BankAccount();
                    }
                    else
                    {
                        account = new BankAccount(answer);
                    }
                    break;

                case FINISH:
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
