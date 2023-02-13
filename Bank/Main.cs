using System;
using OOPBank;

namespace Bank
{
    class BankMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("choose a type of bank account to open: 1 to start without money and 2 to push money in when opening");
            double moneyToAdd = 0;
            while (true)
            {
                int choice1 = int.Parse(Console.ReadLine());
                if (choice1 == 1)
                {
                    Console.WriteLine("you opened a bank account without pushing money. enjoy our terrible services!");
                    break;
                }
                else if (choice1 == 2)
                {
                    Console.WriteLine("how much money would you like to push?");
                    moneyToAdd = double.Parse(Console.ReadLine());
                    Console.WriteLine($"you made a bank account with {moneyToAdd}. welcome to the bank!");
                    break;
                }
                else
                {
                    Console.WriteLine("unknown response. try again");
                }
            }
            BankAccount bAcc = new BankAccount(moneyToAdd);
            int currentYear = 0;
            double currentInterest = 0;
            while (true)
            {
                Console.WriteLine($"current year: {currentYear}");
                Console.WriteLine($"money: " + bAcc.money);
                Console.WriteLine("what would you like to do?");
                Console.WriteLine("1 - push money" +
                    " 2 - pull money" +
                    " 3 - close bank account");
                int input = int.Parse(Console.ReadLine());

                if (input == 1)
                {
                    Console.WriteLine("how much do you want to push?");
                    bAcc.PushMoney(double.Parse(Console.ReadLine()) * (1 + currentInterest));
                }
                else if (input == 2)
                {
                    Console.WriteLine("how much do you want to pull?");
                    bAcc.PullMoney(int.Parse(Console.ReadLine()));
                    bAcc.PushMoney(currentInterest);

                }
                else if (input == 3)
                {
                    Console.WriteLine("NOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOOO");
                    break;
                }
                currentYear++;
                currentInterest = bAcc.calculateInterest(currentYear);
            }
        }
    }
}