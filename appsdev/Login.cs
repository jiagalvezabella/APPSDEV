using System;
using System.Windows.Forms;

namespace ParkingManagement
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            // For demonstration purposes, let's consider a hardcoded username and password
            string validUsername = "korokotong";
            string validPassword = "qwe123";

            if (username == validUsername && password == validPassword)
            {
                MessageBox.Show("Login successful!");
                // If login is successful, open the main form or perform other actions
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide(); // Hide the login form
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}
