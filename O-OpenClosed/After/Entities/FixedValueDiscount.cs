using SOLID_By_Example.O_OpenClosed.After.Interfaces;

namespace SOLID_By_Example.O_OpenClosed.After.Entities
{
    public class FixedValueDiscount : IDiscount
    {
        private readonly decimal DISCOUNT_VALUE_20_FIXED = 20M;

        public decimal Calculate(decimal price) => price - DISCOUNT_VALUE_20_FIXED;
    }
}