// See https://aka.ms/new-console-template for more information
using Bank;
using System.ComponentModel.Design;




public class HelloWorld
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Hello and welcome to Simple Bank ");
        Console.WriteLine("Simplifying Your Finances, Simply with Simple Bank ");
        List<BankAccount> accounts = new List<BankAccount>();
        Helper.Menu(accounts);
    }
}