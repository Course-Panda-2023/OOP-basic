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
        private List<User> userList;

        public void OpenBank()
        {
            bool closeBank = false;
            String input = "";
            while (closeBank == false)
            {
                Console.WriteLine("Hello and welcome to the 666BankOnline services.\n" +
                "Please choose one of the following services by pressing the designated button:\n" +
                "1 - Open a new account\n" +
                "2 - Enter your account\n" +
                "3 - Wait a year\n");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        User u = createAccount();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    default:

                        break;
                }
            }

        }

        public User enterAccount()
        {
            bool isLoggedIn = false;
            while (isLoggedIn == false)
            {
                Console.WriteLine("Enter id");
                try
                {
                    int input = Int32.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {

                }
                foreach (User u in this.userList)
                {
                    if (String.Equals(input, u.Id) == true)
                    {

                    }
                }
            }

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
