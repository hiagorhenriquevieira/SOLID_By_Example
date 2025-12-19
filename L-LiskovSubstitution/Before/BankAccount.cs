using System;

namespace SOLID_By_Example.L_LiskovSubstitution.Before
{
    public class BankAccount
    {
        public decimal Balance { get; protected set; }

        public virtual void Withdraw(decimal value)
        {
            if (value <= 0)
                throw new ArgumentException("Invalid value.");

            if (value > Balance)
                throw new InvalidOperationException("Insufficient funds.");

            Balance -= value;
        }
    }
}
