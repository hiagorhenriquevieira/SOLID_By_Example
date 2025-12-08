using SOLID_By_Example.S_SingleResponsability.After.Interfaces;
using System.Data.SqlClient;

namespace SOLID_By_Example.S_SingleResponsability.After.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(string connectionString)
        {
            Connection = new SqlConnection(connectionString);
            Connection.Open();
            Transaction = Connection.BeginTransaction();
        }

        public SqlConnection Connection { get; }
        public SqlTransaction Transaction { get; }


        public void Commit() => Transaction.Commit();

        public void Rollback() => Transaction.Rollback();
        public void Dispose()
        {
            Transaction.Dispose();
            Connection.Dispose();
        }
    }
}
