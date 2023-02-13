class InvestAccount
{
    private static readonly Random random = new Random();
    private static readonly int maxDelta = 2;
    private static readonly int minDelta = -1;
    
    public int interest{get; set;}
    public double money{get; set;}

    public int GetInterest(){return this.interest;}
    public double GetMoney(){return this.money;}


    public InvestAccount()
    {
        this.money = 0;
        this.interest = 3;
    }
    public InvestAccount(double initDeposit)
    {
        this.money = initDeposit;
        this.interest = 3;
    }

    public void UpdateYear()
    {
        this.interest = Math.Max(0, interest + random.Next(minDelta, maxDelta+1));
        this.money *= (1+this.interest*0.01);
    }

    public void DepositMoney(double amount)
    {
        this.money += amount;
    }
    
    public bool CheckIfWithdrawAllowed(double amount)
    {
        return amount > money;
    }
    public void WithdrawMoney(double amount)
    {
            this.money -= amount;
    }

    ~InvestAccount(){}
}
