namespace SOLID_By_Example.L_LiskovSubstitution.After.Entities
{
    public class SalaryAccount : BankAccount
    {
        public SalaryAccount(decimal initialBalance) : base(initialBalance)
        {
        }
    }
}