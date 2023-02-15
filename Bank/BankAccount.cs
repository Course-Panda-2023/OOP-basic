using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    internal class BankAccount
    {
        private double _balance;
        private string _name;
        private readonly string _id;
        private int _accountNumber;
        private static int _nextAccountNumber = 1;
        private int year;
        private double _currentInterest;
        public BankAccount(string name, string id, double balance)
        {
            this._name = name;
            this._id = id;
            this._balance = balance;
            this._accountNumber = _nextAccountNumber;            
            this._currentInterest = 3;
            _nextAccountNumber++;
        }

        public BankAccount(string name, string id) : this(name, id, 0)
        {
        }
        
        public double Balance
        {
            get
            {
                return _balance;
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public int AccountNumber
        {
            get
            {
                return _accountNumber;
            }
        }
        public void ShiftYear()
        {
            this.year++;
        }
        public void UpdateInterest()
        {
            Random rnd = new Random();
            _currentInterest = Math.Max(_currentInterest + rnd.NextDouble(), 0);
        }
        public double CurrentInterest
        {
            get
            {
                return _currentInterest;
            }
        }
        public void UpdateBalance()
        {
            _balance += _balance * _currentInterest / 100;
        }
        public string ID
        {
            get
            {
                return _id;
            }
        }
        public void Deposit(double amount)
        {
            _balance += amount;
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
        }

        public override string ToString()
        {
            return $"Account {_accountNumber} belongs to {_name} and has a balance of {_balance}";
        }
    }
}
