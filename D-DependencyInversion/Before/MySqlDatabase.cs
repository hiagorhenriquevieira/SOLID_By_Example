using System;

namespace SOLID_By_Example.D_DependencyInversion.Before
{
    public class MySqlDatabase
    {
        public void Save(string data)
        {
            Console.WriteLine($"Saving '{data}' to MySQL database.");
        }
    }

    public class UserService
    {
        private readonly MySqlDatabase _database;

        public UserService()
        {
            _database = new MySqlDatabase();
        }

        public void RegisterUser(string username)
        {
            Console.WriteLine("Validating user...");

            _database.Save(username);

            Console.WriteLine("User registered successfully.");
        }
    }
}
