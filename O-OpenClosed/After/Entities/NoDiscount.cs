using SOLID_By_Example.O_OpenClosed.After.Interfaces;

namespace SOLID_By_Example.O_OpenClosed.After.Entities
{
    public class NoDiscount : IDiscount
    {
        public decimal Calculate(decimal price) => price;
    }
}