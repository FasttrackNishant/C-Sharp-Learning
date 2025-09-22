using System;

namespace Challenge
{
    class SavingsAcct : Account
    {
        private decimal _interestRate;
        private int _discountLimit;

        public SavingsAcct(string firstName, string lastName, decimal interestRate, decimal balance)
            : base(firstName, lastName, balance)
        {
            _interestRate = interestRate;
            _discountLimit = 3;
        }

        public void ApplyInterest()
        {
            _balance += (_balance * _interestRate);
        }

        public override void Withdraw(decimal value)
        {

            if (value > _balance)
            {
                Console.WriteLine("Illegal Operation");
            }
            else if (_discountLimit == 0)
            {
                _balance -= 2.0m;
                _balance -= value;
            }
            else
            {
                _discountLimit--;
                _balance -= value;
            }
        }
    }
}