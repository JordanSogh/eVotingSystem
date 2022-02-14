using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace eVotingSystem
{
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {

       
        public LoginForm()
        {
            // Creates components for the form
            InitializeComponent();
            
        }

        public bool UserLoggedIn { get; private set; }
        public LoginUser PassedUserDetails { get; private set; }

        private void LoginForm_Load(object sender, EventArgs e)
        {


        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(userNameInput.Text))
            {
                MessageBox.Show("You must enter a valid username");
            }
            else if (string.IsNullOrEmpty(passwordInput.Text))
            {
                MessageBox.Show("You must enter a valid password");
            }
            else
            { 
                LoginUser loginDetails = new LoginUser();
                if (loginDetails.ValidateAndLoginUser(userNameInput.Text, passwordInput.Text))
                {
                    Debug.WriteLine("user found in database");
                    PassedUserDetails = loginDetails;
                    UserLoggedIn = true;
                    this.Hide();
                    MainForm mainForm = new MainForm(loginDetails, this);
                    mainForm.Show();
                    userNameInput.Text = "";
                    passwordInput.Text = "";
                }
                else
                {
                    Debug.WriteLine("user not found in database");
                    MessageBox.Show("Incorrect Login Details");
                }
            }

            

        }

        private void userNameInput_Click(object sender, EventArgs e)
        {

        }

        private void passwordInput_Click(object sender, EventArgs e)
        {

        }

        private void userNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
