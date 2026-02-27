using SOLID_By_Example.O_OpenClosed.After.Interfaces;

namespace SOLID_By_Example.O_OpenClosed.After.Entities
{
    public class PercentDiscount : IDiscount
    {
        private const decimal DISCOUNT_10_PERCENT = 0.9m;

        public decimal Calculate(decimal price) => price * DISCOUNT_10_PERCENT;
    }
}