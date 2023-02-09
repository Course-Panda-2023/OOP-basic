using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        The menu for the bank will be here
        Make convenient and intuitive menu
        */
        Bank b = new Bank();
        b.addAccount(100, "1234");
        b.addAccount(120, "12345");
        b.runProgram();
    }
}
