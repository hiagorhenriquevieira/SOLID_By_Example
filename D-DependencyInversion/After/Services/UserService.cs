using SOLID_By_Example.D_DependencyInversion.After.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_By_Example.D_DependencyInversion.After.Services
{
    public class UserService
    {
        private readonly IDatabase _database;

        public UserService(IDatabase database)
        {
            _database = database;
        }

        public void RegisterUser(string username)
        {
            Console.WriteLine("Validating user...");

            _database.Save(username);

            Console.WriteLine("User registered successfully.");
        }
    }
}
