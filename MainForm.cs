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
    public partial class MainForm : MetroFramework.Forms.MetroForm
    {
        private LoginValidator PassedUserDetails;
        User user;
        Voter voter;
        Admin admin;
        Auditor auditor;

        public MainForm(LoginValidator passedDetailsC)
        {
            InitializeComponent();
            PassedUserDetails = passedDetailsC;

            user = new User();
            user.SetLoginDetails(PassedUserDetails.Role,PassedUserDetails.UserName, PassedUserDetails.Password);
            user.GetUserDetails();

            if (user.role == "Voter"){
                voter = new Voter();
                roleLabel.Text = "Voter";
                VoterGroupBox.Show();
                AuditorGroupBox.Hide();
                AdminGroupBox.Hide();
            };
            if (user.role == "Admin")
            {
                admin = new Admin() ;
                roleLabel.Text = "Admin";
                VoterGroupBox.Hide();
                AuditorGroupBox.Hide();
                AdminGroupBox.Show();
            };
            if (user.role == "Auditor")
            {
                auditor = new Auditor();
                roleLabel.Text = "Auditor";
                VoterGroupBox.Hide();
                AuditorGroupBox.Show();
                AdminGroupBox.Hide();
            };

        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {
          
        }

        private void roleLabel_Click(object sender, EventArgs e)
        {



        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        private void VoteButton_Click(object sender, EventArgs e)
        {
            
        }

        private void CreateUser_Click(object sender, EventArgs e)
        {

        }

        private void DeleteUser_Click(object sender, EventArgs e)
        {

        }

        private void UpdateUser_Click(object sender, EventArgs e)
        {

        }

        private void CreateCampaign_Click(object sender, EventArgs e)
        {

        }

        private void AdminGroupBox_Click(object sender, EventArgs e)
        {

        }

        private void VoterGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AuditorGroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
