using System;

namespace Challenge
{
    class Account
    {
        protected string _ownerFN;
        protected string _ownerLN;
        protected decimal _balance;

        public Account(string firstName, string lastName, decimal balance)
        {
            _ownerFN = firstName;
            _ownerLN = lastName;
            _balance = balance;
        }

        public string AccountOwner
        {
            get => $"{_ownerFN} {_ownerLN}";
        }

        public decimal Balance
        {
            get => _balance;
        }

        public void Deposit(decimal value)
        {
            _balance += value;
        }

        public virtual void Withdraw(decimal value)
        {
            _balance -= value;
        }

        public override string ToString()
        {
            return $"Account: Owned by {_ownerFN} {_ownerLN}";
        }

    }
}