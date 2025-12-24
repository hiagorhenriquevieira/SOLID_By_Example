using SOLID_By_Example.O_OpenClosed.After.Interfaces;

namespace SOLID_By_Example.O_OpenClosed.After.Entities
{
    public class BlackFridayDiscount : IDiscount
    {
        private const decimal DISCOUNT_30_PERCENT = 0.7M;
        public decimal Calculate(decimal price) => price * DISCOUNT_30_PERCENT;
    }
}