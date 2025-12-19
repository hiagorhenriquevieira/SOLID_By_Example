using SOLID_By_Example.L_LiskovSubstitution.After.Interfaces;
using System;

namespace SOLID_By_Example.L_LiskovSubstitution.After.Entities
{
    public class CheckingAccount : BankAccount, IAccountWithWithdrawal
    {
        public CheckingAccount(decimal initialBalance) : base(initialBalance)
        {
        }

        public void Withdraw(decimal value)
        {
            if (value <= 0)
                throw new ArgumentException("Invalid value.");

            if (value > Balance)
                throw new InvalidOperationException("Insufficient funds.");

            Balance -= value;
        }
    }
}