using SOLID_By_Example.D_DependencyInversion.After.Interfaces;
using System;

namespace SOLID_By_Example.D_DependencyInversion.After.Infrastructure.Databases
{
    public class PostgreSqlDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to PostgreSQL database.");
        }
    }
}
