using SOLID_By_Example.S_SingleResponsability.After.Entities;

namespace SOLID_By_Example.S_SingleResponsability.After.Interfaces
{
    public interface IInvoiceService
    {
        void GenerateInvoice(Order order);
    }
}
