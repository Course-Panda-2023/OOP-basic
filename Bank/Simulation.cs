using System;

public class Simulation
{
	public static void Main(string[] args)
	{
		Bank b = new Bank(5000);
		bool accountAlive = true;
		while (accountAlive)
		{
			Console.WriteLine("Menu");
			Console.WriteLine("A. Add Money");
			Console.WriteLine("B. Withdraw Money");
			Console.WriteLine("C. Close Account");
			string choosen = Console.ReadLine()!;
			switch (choosen)
			{
				case "A":
					Console.WriteLine("Money To Add:");
					double amount = Convert.ToDouble(Console.ReadLine());
					b.AddMoney(amount);
					Console.WriteLine(b.Balance);
					break;
				case "B":
                    Console.WriteLine("Money To Draw:");
                    double draw = Convert.ToDouble(Console.ReadLine());
					b.WithdrawMoney(draw);
					Console.WriteLine(b.Balance);
					break;
				case "C":
					accountAlive= false;
					Console.WriteLine("Close Account");
					break;
			}
			b.CalcInterest();
			b.UpdateBalance();
		}
	}
}
