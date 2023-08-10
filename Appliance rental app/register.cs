using Appliance_rental_app.Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Appliance_rental_app
{
    public partial class register : MaterialForm
    {
        public register()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            login l = new login();

            l.Visible = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {

            // Retrieve username and password from input fields
            string username = txtUser.Text;
            string password = txtPass.Text;

            // Create a new instance of the Customer class
            Customer customer = new Customer();

            // Check if the customer already exists
            if (customer.CheckIfCustomerExists(username))
            {
                MessageBox.Show("Customer already exists. Please choose a different username.");
                return;
            }

            // Set the username and password properties
            customer.username = username;
            customer.password = password;

            try
            {
                // Call the RegCustomer method
                customer.RegCustomer();

                // Registration successful
                MessageBox.Show("Registration successful!");
                this.Visible = false;
                login l = new login();
                l.Visible = true;
            }
            catch (Exception ex)
            {
                // Handle the exception appropriately
                MessageBox.Show("An error occurred during registration: " + ex.Message);
            }
        }
    }
}
