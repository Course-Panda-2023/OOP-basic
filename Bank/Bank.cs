using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Bank
{
    private double balance;
	public double Balance 
	{
		get { return balance; }
		set { balance = value; }
	}
	private double interest = 3;
    public Bank()
	{
		 this.balance = 0;
	}

	public Bank (double balance)
	{
		this.balance = balance;
	}
	
	public void CalcInterest()
	{
		Random rnd = new Random();
		int randomNumber = rnd.Next(-1, 2);
		this.interest += randomNumber;
		if (this.interest < 0)
			this.interest = 0;
	}
	public void AddMoney(double amount)
	{
		this.balance += amount;
	}
	public void WithdrawMoney(double amount)
	{
		if (amount > this.Balance)
			Console.WriteLine("You dont have enough money");
		else
			this.Balance -= amount;
	}
	~Bank()
	{
		Console.WriteLine(this.balance);
		Console.WriteLine("Close This Account");
	}
	public void UpdateBalance() 
	{
		this.balance *= (1 + this.interest / 100) ;
	}
}
