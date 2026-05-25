using SOLID_By_Example.D_DependencyInversion.After.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_By_Example.D_DependencyInversion.After.Infrastructure.Databases
{
    public class MySqlDatabase : IDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to MySQL database.");
        }
    }
}
