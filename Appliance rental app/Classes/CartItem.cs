using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_rental_app.Classes
{
    public class CartItem
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int ApplianceId { get; set; }

        private static MySqlConnection connection;



        public CartItem(int id, int customerId, int applianceId)
        {
            Id = id;
            CustomerId = customerId;
            ApplianceId = applianceId;
        }


        public static decimal CalculateTotalPrice(List<CartItem> cartItems)
        {
            string connectionString = "server=localhost;database=appliance_rental;user=root;";
            decimal totalPrice = 0;

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT SUM(a.monthly_fee) " +
                                   "FROM appliances a " +
                                   "WHERE a.appliance_id IN (";
                    string parameterNames = string.Join(", ", cartItems.Select((_, index) => $"@ApplianceId{index}"));
                    query += parameterNames + ")";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    for (int i = 0; i < cartItems.Count; i++)
                    {
                        command.Parameters.AddWithValue($"@ApplianceId{i}", cartItems[i].ApplianceId);
                    }

                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        totalPrice = Convert.ToDecimal(result);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while calculating the total price: " + ex.Message);
            }

            return totalPrice;
        }

    }
}
