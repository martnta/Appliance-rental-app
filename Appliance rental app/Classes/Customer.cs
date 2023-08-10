using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appliance_rental_app.Classes
{
    public class Customer
    {

        public int CustomerId { get; set; }

        public string username { get; set; }
        public string password { get; set; }

        private MySqlConnection connection;
        private string connectionString;

        //calling connection
        public Customer()
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
                    string query = "SELECT COUNT(*) FROM customer WHERE username = @Username AND password = @Password";
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


        //check if alredy exists 

        public bool CheckIfCustomerExists(string username)
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM customer WHERE username = @Username";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    return count > 0;
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while checking if the customer exists: " + ex.Message);
                return false;
            }
        }
        public void RegCustomer()
        {
            try
            {
                using (connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO customer (username, password) VALUES (@Username, @Password)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while registering customer: " + ex.Message);
            }
        }

    

        // veiw all appliances


        //add to cart table
        public void AddToCart(Appliance appliance)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    int customerId = CustomerId;

                    // Create a new cart item with the customer ID and appliance ID
                    CartItem cartItem = new CartItem(0,customerId, appliance.Id);

                    // Insert the cart item into the database
                    string query = "INSERT INTO cart (customer_id, appliance_id) VALUES (@CustomerId, @ApplianceId)";
                    MySqlCommand command = new MySqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CustomerId", cartItem.CustomerId);
                    command.Parameters.AddWithValue("@ApplianceId", cartItem.ApplianceId);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                // Handle exception
                Console.WriteLine("An error occurred while adding an appliance to the cart: " + ex.Message);
            }
        }




        public decimal CalculateTotalPrice(List<CartItem> cartItems)
        {
            return CartItem.CalculateTotalPrice(cartItems);
        }
    }

}
