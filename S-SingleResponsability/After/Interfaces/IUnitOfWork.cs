using System.Data.SqlClient;

namespace SOLID_By_Example.S_SingleResponsability.After.Interfaces
{
    public interface IUnitOfWork
    {
        SqlConnection Connection { get; }
        SqlTransaction Transaction { get; }
        void Commit();
        void Rollback();
        void Dispose();
    }
}