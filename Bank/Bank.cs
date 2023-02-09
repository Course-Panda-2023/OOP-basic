using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Investment
{
    internal class Bank
    {
        private double interest;
        private List<User> userList;
        private int currentYear;

        public Bank()
        {
            this.currentYear = 0;
            this.userList = new List<User>();
            this.interest = 0.03;
        }

        public void OpenBank()
        {
            bool closeBank = false;
            String input = "";
            int money = 0;
            while (closeBank == false)
            {
                Console.WriteLine("Hello and welcome to the 666BankOnline services.\n" +
                "Please choose one of the following services by pressing the designated button:\n" +
                "1 - Open a new account\n" +
                "2 - Enter your account\n" +
                "3 - Wait a year\n" +
                "4 - remove an account");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        User u = createAccount();
                        this.userList.Add(u);
                        break;
                    case "2":
                        User uenter = enterAccount();
                        Console.WriteLine("How much money would you like to deposit?");
                        bool isMoneyValid = false;
                        while (isMoneyValid == false)
                        {
                            try
                            {
                                money = Int32.Parse(Console.ReadLine());
                                isMoneyValid = true;
                            }
                            catch (Exception ex) { Console.WriteLine("Invalid amount"); }
                            uenter.addBalance(money);
                        }

                        break;
                    case "3":
                        waitYear();
                        break;
                    case "4":
                        User uremove = removeAccount();
                        this.userList.Remove(uremove);
                        break;
                    default:
                        Console.WriteLine("Try again");
                        break;
                }
            }

        }

        public double Interest()
        {
            Random r = new Random();
            double delta = r.NextDouble() * 3 - 1;
            if (this.interest + delta < 0)
            {
                this.interest = 0;
                return 0;
            }
            double tempInterest = this.interest;
            this.interest += delta;
            return tempInterest + delta;
        }

        public void waitYear()
        {
            double currentInterest = Interest();
            foreach (User u in this.userList)
            {
                u.addBalance(u.AccountBalance * currentInterest);
            }
            currentYear++;
        }

        public User removeAccount()
        {
            bool isLoggedIn = false;
            int input = 0;
            String inputStr = "";
            while (isLoggedIn == false)
            {
                Console.WriteLine("Enter id");
                try
                {
                    input = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid Id.");
                }
                foreach (User u in this.userList)
                {
                    if (input == u.Id)
                    {
                        Console.WriteLine("Enter password:");
                        inputStr = Console.ReadLine();
                        if (u.checkPassword(inputStr) == true)
                        {
                            Console.WriteLine("Removing account...");
                            return u;
                        }
                    }
                }
                Console.WriteLine("User id not in our system, or password is invalid.");
            }
            return null;
        }

        public User enterAccount()
        {
            bool isLoggedIn = false;
            int input = 0;
            String inputStr = "";
            while (isLoggedIn == false)
            {
                Console.WriteLine("Enter id");
                try
                {
                    input = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("invalid Id.");
                }
                foreach (User u in this.userList)
                {
                    if (input == u.Id)
                    {
                        Console.WriteLine("Enter password:");
                        inputStr = Console.ReadLine();
                        if (u.checkPassword(inputStr) == true)
                        {
                            Console.WriteLine("Entering account...");
                            return u;
                        }
                    }
                }
                Console.WriteLine("User id not in our system, or password is invalid.");
            }
            return null;
        }
        public static User createAccount()
        {
            Console.WriteLine("Hello, and thank you for choosing 666BankingOnline\n To open your account, please, enter your name below:");
            String userName = Console.ReadLine();
            Console.WriteLine("Welcome " + userName + ".\nIn only a few short steps, you will have your account ready to go!" +
                "Please enter a valid id number");
            bool isIdValid = false;
            int userId = 0;
            while (isIdValid == false)
            {
                try
                {
                    userId = Int32.Parse(Console.ReadLine());
                    isIdValid = true;
                    if (userId <= 0)
                    {
                        isIdValid = false;
                        Console.WriteLine("Invalid id, reenter your id please.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid id, reenter your id please.");
                }
            }
            Console.WriteLine("Very well.\nAll that's left for you is to set your password.\nYour password is your own and" +
                "you should never tell it to anyone.");
            String userPassword = "";
            bool isPasswordValid = false;
            while (isPasswordValid == false)
            {
                isPasswordValid = true;
                userPassword = Console.ReadLine();
                int len = userPassword.Length;
                if (len == 0)
                {
                    Console.WriteLine("No password entered. Reenter password.");
                    isPasswordValid = false;
                }
                else
                {
                    foreach (char c in userPassword)
                    {
                        int asciValue = (int)c;
                        if (asciValue < 48 || (asciValue < 65 && asciValue > 57) || (asciValue < 97 && asciValue > 90) ||
                            (asciValue < 128 && asciValue > 122))
                        {
                            Console.WriteLine("Invalid password! Only letters and numbers allowed. Reenter password.");
                            isPasswordValid = false;
                        }
                    }
                }
            }
            User newUser = new User(0, userName, userId, userPassword);
            Console.WriteLine("Well done, now both your money and your soul is ours:)\n" +
                "Your current account balance is: 0$");
            return newUser;
        }
    }


}
