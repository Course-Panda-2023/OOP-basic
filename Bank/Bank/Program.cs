
namespace Bank
{
    class Program
    {
        public static void Main(string[] args)
        {
            Bank b = new Bank("Isreal", 123, true);

            User u1 = new User(123456789, "Emily", "emily@gmail.com", "password1");
            User u2 = new User(987654321, "Jonathan", "jj@gmail.com", "password2");
            User u3 = new User(159238294, "Ethan", "ethan321@gmail.com", "password11");

            Account a1 = new Account(111, u1, 0);
            Account a2 = new Account(321, u2, 123456789);
            Account a3 = new Account(123, u3, 10);

            b.AddAccount(a1);
            b.AddAccount(a2);
            b.AddAccount(a3);

            b.PrintAccounts();
            Console.WriteLine();

            b.SetNewYear(false);
            b.PullMoney(159238294, 30);

            b.PrintAccounts();
            Console.WriteLine();

            b.SetNewYear(true);
            b.PullMoney(987654321, 100000000);
            b.DepositMoney(987654321, 100000000000);
            b.DepositMoney(123456789, 9000000);

            b.PrintAccounts();
            Console.WriteLine();

            b.CloseAccount(987654321);
            Console.WriteLine();

            b.PrintAccounts();
            Console.WriteLine();
        }
    }
}
