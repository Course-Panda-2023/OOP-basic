namespace OOP.InvestmentAccount;

public class Test
{
    public static void Main(string[] args)
    {
        InvestmentAccount I = new InvestmentAccount(500);
        
        Console.WriteLine(I.GetSum());
        I.Deposit(200);
        Console.WriteLine(I.GetSum());
        
        I.Cache(200);
        Console.WriteLine(I.GetSum());
        
        I.CloseAccount();
        
        I.Cache(200);
        I.Deposit(200);
    }
}