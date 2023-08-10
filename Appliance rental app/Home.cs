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
    public partial class Home : MaterialForm
    {
        private Appliance appliance;

        private Customer customer;
        private int customerId;
        public Home(int customerId)
        {
            InitializeComponent();
            appliance = new Appliance();
            customer = new Customer();

            this.customerId = customerId;
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Teal900, Primary.Teal600, Primary.Teal500, Accent.Teal700, TextShade.WHITE);
        }

        private void Home_Load(object sender, EventArgs e)
        {
            DisplayAllAppliances();
        }

        private void DisplayAllAppliances()
        {

            // Clear existing data in the DataGridView
            dgvAppliances.Rows.Clear();

            // Call the GetAllAppliances method
            var appliances = appliance.GetAllAppliances();

            dgvAppliances.DataSource = appliances;

        }

        void loadSort()
        {
           

            // Call the GetAllAppliances method
            var sorted = appliance.ViewSorted();

            dgvAppliances.DataSource = sorted;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string color = txtColo.Text;
            string dimension = txtdime.Text;
            string energy = txtEnerg.Text;
            string fee = txtFee.Text;

          

            if (string.IsNullOrWhiteSpace(brand) || string.IsNullOrWhiteSpace(fee))
            {
                MessageBox.Show("Empty fields!");
                return;
            }
            else
            {

            }

          

            
           
            

           

        

        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            loadSort();
        }

        private void dgvAppliances_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAppliances.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgvAppliances.SelectedRows[0];
                    int applianceId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    Appliance selectedAppliance = appliance.GetAppById(applianceId);

                    // Handle the selected appliance object
                    if (selectedAppliance != null)
                    {
                        
                        txtColo.Text = selectedAppliance.Color;
                        txtBrand.Text = selectedAppliance.Name;
        

                        // Enable buttons or perform additional actions based on the selection
                        btnAddToCart.Enabled = true;
                    }
                    else
                    {
                        // Handle the case where the selected appliance is not found
                        // Display an error message or perform any required actions
                        MessageBox.Show("Selected appliance not found.");
                    }
                }
                catch (Exception ex)
                {
                    // Handle the exception appropriately (e.g., display an error message, log the error)
                    MessageBox.Show("An error occurred while retrieving the appliance details: " + ex.Message);
                }
            }
        }

      private void btnSearch_Click(object sender, EventArgs e)
        {
            string type = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(type))
            {
                MessageBox.Show("Please enter a search type.");
             
                return;
            }

            List<Appliance> searchResults = appliance.SearchAppliances(type);
            dgvAppliances.DataSource = searchResults;

            // Refresh the DataGridView
            dgvAppliances.Refresh();
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            cart c = new cart();
            c.Visible = true;
        }
    }
}
