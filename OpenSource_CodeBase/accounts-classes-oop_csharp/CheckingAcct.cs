using System;

namespace Challenge
{
    class CheckingAcct : Account
    {
        public CheckingAcct(string firstName, string lastName, decimal balance)
            : base(firstName, lastName, balance)
        { }

        public override void Withdraw(decimal value)
        {
            if (value > _balance)
            {
                _balance -= 35m;
                _balance -= value;
            }
            else
            {
                _balance -= value;
            }
        }
    }
}