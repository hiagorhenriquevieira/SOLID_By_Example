namespace SOLID_By_Example.L_LiskovSubstitution.Before
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }
    }
}
