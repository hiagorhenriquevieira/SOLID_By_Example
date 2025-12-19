using SOLID_By_Example.L_LiskovSubstitution.After.Interfaces;
using SOLID_By_Example.L_LiskovSubstitution.Before;
using SOLID_By_Example.O_OpenClosed.After.Entities;
using SOLID_By_Example.O_OpenClosed.After.Services;
using SOLID_By_Example.O_OpenClosed.Before;
using System;

namespace SOLID_By_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            OpenClosedAfter();
            OpenClosedBefore();

            LiskovSubstitutionBefore();
            LiskovSubstitutionAfter();
        }

        private static void OpenClosedBefore()
        {
            var calculator = new MessyPriceCalculator();

            decimal originalPrice = 100;

            decimal finalPrice = calculator.Calculate(originalPrice, "Black_Friday_Coupon");

            Console.WriteLine($"Final price to be paid: {finalPrice}");
        }

        private static void OpenClosedAfter()
        {
            var calculator = new PriceCalculator();

            decimal originalPrice = 100;

            decimal finalPrice = calculator.Calculate(originalPrice, new BlackFridayDiscount());

            Console.WriteLine($"Final price to be paid:{finalPrice}");
        }

        private static void LiskovSubstitutionBefore()
        {
            var salaryAccount = new SalaryAccount(initialBalance: 500);

            ProcesswithdrawalBefore(salaryAccount);

            var chekingAccount = new CheckingAccount(initialBalance: 600);

            ProcesswithdrawalBefore(chekingAccount);
        }

        private static void ProcesswithdrawalBefore(BankAccount account)
        {
            account.Withdraw(value: 100);
        }

        private static void LiskovSubstitutionAfter()
        {
            var salaryAccount = new L_LiskovSubstitution.After.Entities.SalaryAccount(initialBalance: 500);
            //It's not possible to pass the payroll account into the processing, as it results in a compilation error and there's no need to throw an exception.
            //ProcesswithdrawalAfter(salaryAccount);

            var checkingAccount = new L_LiskovSubstitution.After.Entities.CheckingAccount(initialBalance: 600);

            ProcesswithdrawalAfter(checkingAccount);
        }

        private static void ProcesswithdrawalAfter(IAccountWithWithdrawal account)
        {
            account.Withdraw(100);
        }
    }
}