using System;

namespace SOLID_By_Example.L_LiskovSubstitution.Before
{
    public class SalaryAccount : BankAccount
    {
        public SalaryAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }

        public override void Withdraw(decimal value)
        {
            throw new InvalidOperationException("Salary account does not allow withdrawals.");
        }
    }
}