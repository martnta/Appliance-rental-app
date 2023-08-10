using Appliance_rental_app.Classes;
using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Appliance_rental_app
{
    public partial class Admin : MaterialForm
    {
        private Appliance appliance;
        private BindingList<Appliance> appliances;

        public Admin()
        {
            InitializeComponent();

            appliance = new Appliance();
            appliances = new BindingList<Appliance>();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            DisplayAllAppliances();
        }

        private void DisplayAllAppliances()
        {
            try
            {
                appliances = new BindingList<Appliance>(appliance.GetAllAppliances());
                dataGridView1.DataSource = appliances;
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while retrieving appliances: " + ex.Message);
            }
        }

        private int GetSelectedAppId()
        {
            int applianceId = 0;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    applianceId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            return applianceId;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            int applianceId = GetSelectedAppId();

            try
            {
                Administrator admin = new Administrator();
                admin.DeleteAppliance(applianceId);
                Clear();


                // Refresh the DataGridView
                MessageBox.Show("Deleted successfully");
                DisplayAllAppliances();
             
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int applianceId = GetSelectedAppId();

            if (applianceId == 0)
            {
                MessageBox.Show("No appliance selected.");
                return;
            }

            
            string brand = txtBrand.Text;
            string type = txtType.Text;
            string description = txtdime.Text;
            string color = txtColo.Text;
            string model = txtMod.Text;
            decimal energyConsumption = Convert.ToDecimal(txtEnerg.Text);
            decimal monthlyFee = Convert.ToDecimal(txtFee.Text);

            Appliance editApp = new Appliance()
            {
                Id = applianceId,
                Name = brand,
                Type = type,
                Model = model,
                Color = color,
                Description = description,
                EnergyConsumption = energyConsumption,
                MonthlyFee = monthlyFee
            };

            try
            {
                Administrator admin = new Administrator();
                admin.EditAppliance(editApp);
               

                Clear();
                // Refresh the DataGridView
                DisplayAllAppliances();
                MessageBox.Show("Edited successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string brand = txtBrand.Text;
            string type = txtType.Text;
            string description = txtdime.Text;
            string color = txtColo.Text;
            string model = txtMod.Text;
            decimal energyConsumption = Convert.ToDecimal(txtEnerg.Text);
            decimal monthlyFee = Convert.ToDecimal(txtFee.Text);

            Appliance newApp = new Appliance
            {
                Name = brand,
                Type = type,
                Description = description,
                Model = model,
                Color = color,
                EnergyConsumption = energyConsumption,
                MonthlyFee = monthlyFee
            };

            try
            {
                Administrator admin = new Administrator();
                admin.AddAppliance(newApp);
              

                Clear();
                // Refresh the DataGridView
                DisplayAllAppliances();
                MessageBox.Show("Created successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                    int applianceId = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                    Appliance selectedAppliance = appliance.GetAppById(applianceId);

                    if (selectedAppliance != null)
                    {
                        txtColo.Text = selectedAppliance.Color;
                        txtBrand.Text = selectedAppliance.Name;
                        txtdime.Text = selectedAppliance.Description;
                        txtEnerg.Text = selectedAppliance.EnergyConsumption.ToString();
                        txtMod.Text = selectedAppliance.Model;
                        txtType.Text = selectedAppliance.Type;
                        txtFee.Text = selectedAppliance.MonthlyFee.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Selected appliance not found.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void Clear()
        {
            txtBrand.Text = "";
            txtType.Text = "";
            txtdime.Text = "";
            txtColo.Text = "";
            txtMod.Text = "";
            txtEnerg.Text = "";
            txtFee.Text = "";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            login l = new login();
            l.Visible = true;
        }
    }
}
