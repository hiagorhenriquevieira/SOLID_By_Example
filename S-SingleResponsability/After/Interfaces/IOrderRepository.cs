using SOLID_By_Example.S_SingleResponsability.After.Entities;

namespace SOLID_By_Example.S_SingleResponsability.After.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);
    }
}