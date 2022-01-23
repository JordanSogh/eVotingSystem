using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace eVotingSystem
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            // Creates components for the form
            InitializeComponent();
        }

        



        private void LoginForm_Load(object sender, EventArgs e)
        {


        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void usernameLabel_Click(object sender, EventArgs e)
        {

        }

        private void passwordLabel_Click(object sender, EventArgs e)
        {

        }

        private void usernameInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(usernameInput.Text))
            {
                MessageBox.Show("You must enter a valid username");
            }
            else if (string.IsNullOrEmpty(passwordInput.Text))
            {
                MessageBox.Show("You must enter a valid password");
            }
            else
            {
                User user = new User();
                user.LoginUser(usernameInput.Text, passwordInput.Text);
            }

        }

        private void showUsernameButton_Click(object sender, EventArgs e)
        {

        }

        private void showPasswordButton_Click(object sender, EventArgs e)
        {

        }
    }
}
