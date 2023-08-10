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
    public partial class login : MaterialForm
    {
        private Customer c;
        private int loginAttempts = 0;
        private Timer loginTimer;
        public login()
        {
            InitializeComponent();

            c = new Customer();

            loginTimer = new Timer();
            loginTimer.Interval = 10000;
            loginTimer.Tick += LoginTimer_Tick;
            int customerId = c.CustomerId;

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

        }

        private void LoginTimer_Tick(object sender, EventArgs e)
        {

            loginAttempts = 0;
            loginTimer.Stop();
            materialButton1.Enabled = true;
           
           
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register r = new register();
            r.Visible = true;
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text;
            string password = txtPass.Text;

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

         
//          Customer c = new Customer();
            c.username = username;
            c.password = password;


            Administrator a = new Administrator();
            a.username = username;
            a.password = password;

            if ( a.Login() )
            {
                this.Visible = false;
                Admin ad = new Admin();
                ad.Visible = true;

            }
               else if (c.Login())
            {
               

                this.Visible = false;
                Home h = new Home(c.CustomerId);
                h.Visible = true;
            }else
            {
                loginAttempts++;
                int remainingAtt = 3 - loginAttempts;
                MessageBox.Show("Invalid login credentials. Please try again.Remaining attempts:" + remainingAtt);

                if (loginAttempts >= 3)
                {
                    MessageBox.Show("You have exceeded the maximum number of login attempts. Please try again later.");
                    materialButton1.Enabled = false;
                    lblError.Visible = true;
                    loginTimer.Start();
                    return;

           

                }

              
                    



            }


        }

        private void login_Load(object sender, EventArgs e)
        {
            lblError.Visible = false;
        }
    }
}
