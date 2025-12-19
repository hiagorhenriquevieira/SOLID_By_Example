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
            var account = new SalaryAccount(initialBalance: 500);

            account.Withdraw(value: 100);
        }
    }
}