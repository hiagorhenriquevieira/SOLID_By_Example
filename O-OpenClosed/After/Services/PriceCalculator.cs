using SOLID_By_Example.O_OpenClosed.After.Interfaces;

namespace SOLID_By_Example.O_OpenClosed.After.Services
{
    public class PriceCalculator
    {
        public decimal Calculate(decimal price, IDiscount discountType) => discountType.Calculate(price);
    }
}