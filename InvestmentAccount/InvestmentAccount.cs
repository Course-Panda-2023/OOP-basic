namespace OOP.InvestmentAccount;

public class InvestmentAccount
{
    private bool _isClosed = false;
    private double _sum;

    private double Sum
    {
        get => this._sum;
        set
        {
            this._sum = (1 + this._interestPct / 100) * value;
            this.UpdateInterestRate();
        }
    }
    
    private double _interestPct = 3;

    public InvestmentAccount(double initialSum)
    {
        if (initialSum < 0)
        {
            throw new Exception("Can't initialize an account with a negative balance");
        }
        this.Sum = initialSum;
    }

    private void UpdateInterestRate()
    {
        Random random = new Random();
        this._interestPct = Math.Max(0, this._interestPct + random.NextInt64(-1, 3));
    }

    private void AddToBalance(double sum)
    {
        this.Sum += sum;  // the setter method will take care of the interest rate
    }

    public void Deposit(double sum)
    {
        if (this._isClosed)
        {
            throw new Exception("Account is closed, can't deposit money.");
        }
        this.AddToBalance(sum);
    }

    public void Cache(double sum)
    {
        if (this._isClosed)
        {
            throw new Exception("Account is closed, can't cache money.");
        }
        this.AddToBalance(-sum);
    }

    public void CloseAccount()
    {
        if (this._isClosed)
        {
            throw new Exception("Account is already closed, can't close it again.");
        }
        
        this._isClosed = true;
        Console.WriteLine($"Your balance: {this.Sum}");
    }

    public double GetSum()
    {
        return this.Sum;
    }
}