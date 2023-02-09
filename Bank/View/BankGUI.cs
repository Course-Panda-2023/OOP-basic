using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.View
{
    internal interface BankGUI
    {
        /// <summary>
        /// function welcome user to the system
        /// </summary>
        void Welcome();

        /// <summary>
        /// function prints all the instructions to the user
        /// </summary>
        void OperationsInstruction();

        /// <summary>
        /// gets the operation from the user
        /// </summary>
        /// <returns>returns the specific operation</returns>
        char InputAnOperation();

        string OpenNewAccount();

        /// <summary>
        /// prints the date to the user
        /// </summary>
        void Date();

        double Deposit();
        double Withdraw();
        void CloseAccount(double balance);
    }
}
