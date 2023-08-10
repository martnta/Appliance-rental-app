using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_rental_app.Classes
{
    public class Appliance
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Description { get; set; }
        public decimal EnergyConsumption { get; set; }
        public decimal MonthlyFee { get; set; }
        public string Color { get; set; }

        private readonly MySqlConnection connection;
        private readonly string connectionString;

        public Appliance()
        {
            connectionString = DatabaseConnection.Instance.GetConnection().ConnectionString;
            connection = new MySqlConnection(connectionString);
        }

        public List<Appliance> SearchAppliances(string type)
        {
            List<Appliance> appliances = new List<Appliance>();

            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "SELECT * FROM appliance WHERE type = @Type";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Type", type);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["appliance_id"]);
                            string name = reader["name"].ToString();
                            string description = reader["dimensions"].ToString();
                            string color = reader["color"].ToString();
                            string model = reader["model"].ToString();
                            decimal energyConsumption = Convert.ToDecimal(reader["energy_consumption"]);
                            decimal monthlyFee = Convert.ToDecimal(reader["monthly_fee"]);

                            Appliance appliance = new Appliance()
                            {
                                Id = id,
                                Name = name,
                                Type = type,
                                Color = color,
                                Model = model,
                                Description = description,
                                EnergyConsumption = energyConsumption,
                                MonthlyFee = monthlyFee
                            };

                            appliances.Add(appliance);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while searching for appliances: " + ex.Message);
            }

            return appliances;
        }
        public List<Appliance> GetAllAppliances()
        {
            List<Appliance> appliances = new List<Appliance>();

            try
            {
                using (connection)
                {
                    connection.Open();

                    string query = "SELECT * FROM appliance ";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["appliance_id"]);
                            string name = reader["name"].ToString();
                            string type = reader["type"].ToString();
                            string model = reader["model"].ToString();
                            string description = reader["dimensions"].ToString();
                            string color = reader["color"].ToString();
                            decimal energyConsumption = Convert.ToDecimal(reader["energy_consumption"]);
                            decimal monthlyFee = Convert.ToDecimal(reader["monthly_fee"]);

                            Appliance appliance = new Appliance()
                            {
                                Id = id,
                                Name = name,
                                Type = type,
                                Color = color,
                                Model = model,
                                Description = description,
                                EnergyConsumption = energyConsumption,
                                MonthlyFee = monthlyFee
                            };

                            appliances.Add(appliance);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while retrieving appliances: " + ex.Message);
            }

            return appliances;
        }

        public List<Appliance> ViewSorted()
        {
            List<Appliance> appliances = new List<Appliance>();

            try
            {
                using (connection)
                {
                    connection.Open();

                    string query = "SELECT * FROM appliance ORDER BY energy_consumption DESC";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["appliance_id"]);
                            string name = reader["name"].ToString();
                            string type = reader["type"].ToString();
                            string color = reader["color"].ToString();
                            string model = reader["model"].ToString();
                            string description = reader["dimensions"].ToString();
                            decimal energyConsumption = Convert.ToDecimal(reader["energy_consumption"]);
                            decimal monthlyFee = Convert.ToDecimal(reader["monthly_fee"]);

                            Appliance appliance = new Appliance()
                            {
                                Id = id,
                                Name = name,
                                Type = type,
                                Color = color,
                                Model = model,
                                Description = description,
                                EnergyConsumption = energyConsumption,
                                MonthlyFee = monthlyFee
                            };
                            appliances.Add(appliance);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while retrieving appliances: " + ex.Message);
            }

            return appliances;
        }

        public Appliance GetAppById(int Id)
        {
            try
            {
                using (connection )
                {
                    connection.Open();
                    string query = "SELECT * FROM appliance WHERE appliance_id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", Id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            int id = Convert.ToInt32(reader["appliance_id"]);
                            string name = reader["name"].ToString();
                            string type = reader["type"].ToString();
                            string model = reader["model"].ToString();
                            string color = reader["color"].ToString();
                            string description = reader["dimensions"].ToString();
                            decimal energyConsumption = Convert.ToDecimal(reader["energy_consumption"]);
                            decimal monthlyFee = Convert.ToDecimal(reader["monthly_fee"]);

                            Appliance appliance = new Appliance()
                            {
                                Id = id,
                                Name = name,
                                Type = type,
                                Color = color,
                                Model = model,
                                Description = description,
                                EnergyConsumption = energyConsumption,
                                MonthlyFee = monthlyFee
                            };

                            return appliance;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while retrieving appliance by ID: " + ex.Message);
            }

            // If no matching appliance found or an exception occurred, return null or throw an exception
            return null; // or throw an exception
        }

    }
}
