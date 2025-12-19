namespace SOLID_By_Example.L_LiskovSubstitution.After.Entities
{
    public class BankAccount
    {
        public decimal Balance { get; protected set; }

        protected BankAccount(decimal initialBalance)
        {
            Balance = initialBalance;
        }
    }
}