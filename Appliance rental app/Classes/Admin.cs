using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_rental_app.Classes
{
    public class Administrator
    {
        public string Id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        private MySqlConnection connection;
        private string connectionString;

        public Administrator()
        {
            connectionString = DatabaseConnection.Instance.GetConnection().ConnectionString;
        }

        public bool Login()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM admin WHERE username = @Username AND password = @Password";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred during login: " + ex.Message);
                return false;
            }
        }


        public void AddAppliance(Appliance appliance)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO appliance (name, type, dimensions,model, color, energy_consumption, monthly_fee) VALUES (@Name, @Type, @Dimensions,@Model,@Color, @EnergyConsumption, @MonthlyFee)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", appliance.Name);
                    command.Parameters.AddWithValue("@Type", appliance.Type);
                    command.Parameters.AddWithValue("@Model", appliance.Model);
                    command.Parameters.AddWithValue("@Color", appliance.Color);
                    command.Parameters.AddWithValue("@Dimensions", appliance.Description);
                    command.Parameters.AddWithValue("@EnergyConsumption", appliance.EnergyConsumption);
                    command.Parameters.AddWithValue("@MonthlyFee", appliance.MonthlyFee);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while adding an appliance: " + ex.Message);
            }
        }

        public void EditAppliance(Appliance appliance)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE appliance SET name = @Name, type = @Type, color = @Color, dimensions = @Dimensions, energy_consumption = @EnergyConsumption, model = @Model, monthly_fee = @MonthlyFee WHERE appliance_id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Name", appliance.Name);
                    command.Parameters.AddWithValue("@Type", appliance.Type);
                    command.Parameters.AddWithValue("@Model", appliance.Model);
                    command.Parameters.AddWithValue("@Color", appliance.Color);
                    command.Parameters.AddWithValue("@Dimensions", appliance.Description);
                    command.Parameters.AddWithValue("@EnergyConsumption", appliance.EnergyConsumption);
                    command.Parameters.AddWithValue("@MonthlyFee", appliance.MonthlyFee);
                    command.Parameters.AddWithValue("@Id", appliance.Id);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while editing an appliance: " + ex.Message);
            }
        }

        public void DeleteAppliance(int applianceId)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM appliance WHERE appliance_id = @Id";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Id", applianceId);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while deleting an appliance: " + ex.Message);
            }
        }
    }

}
