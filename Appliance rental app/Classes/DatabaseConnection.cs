using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_rental_app.Classes
{
    class DatabaseConnection
    {

        private static readonly DatabaseConnection instance = new DatabaseConnection();
        private readonly string connectionString;

        private DatabaseConnection()
        {
            // Set the connection string for the database
            connectionString = "server=localhost;database=appliance_rental;user=root;";
        }

        public static DatabaseConnection Instance { get { return instance; } }

        public MySqlConnection GetConnection()
        {
            try
            {
                MySqlConnection connection = new MySqlConnection(connectionString);
                Console.WriteLine("connected");
                return connection;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately (e.g., logging, displaying an error message)
                Console.WriteLine("Error connecting to the database: " + ex.Message);
                return null;
            }
        }
    }
}
