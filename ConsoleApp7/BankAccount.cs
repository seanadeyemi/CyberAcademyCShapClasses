using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{

    public class BankAccount
    {
        public BankAccount()
        {
            _balance = 20000;
        }
        public BankAccount(decimal initialBalance)
        {
            _balance = initialBalance;
        }

        public BankAccount(string accountNumber) : this()
        {
            _accountNumber = accountNumber;
        }


        private string? _accountNumber;

        // Private field: hidden from outside
        private decimal _balance;
        // Public method to access or modify the balance safely
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
              //  balance += amount;
              _balance = _balance + amount;
            }
        }
        public void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= _balance)
            {
                _balance -= amount;
            }
        }
        public decimal GetBalance()
        {
            return _balance;
        }

        public decimal Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value >= 0)
                {
                    _balance = value;
                }
            }
        }

    }

}
