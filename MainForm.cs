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

        private UserControls.VoterControl voterControl1;
        private UserControls.AdminControl adminControl2;
        private UserControls.AuditorControl auditorControl2;

        public MainForm(LoginValidator passedDetailsC)
        {
            InitializeComponent();
            PassedUserDetails = passedDetailsC;

        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {
            user = new User();
            user.SetLoginDetails(PassedUserDetails.Role, PassedUserDetails.UserName, PassedUserDetails.Password);
            user.GetUserDetails();

            

            if (user.role == "Voter")
            {
                voter = new Voter();
                roleLabel.Text = "Voter";
                voterControl1.Show();
                voterControl1.GetUser(user);
                
            };
            if (user.role == "Admin")
            {
                admin = new Admin();
                roleLabel.Text = "Admin";
                adminControl2.Show();
                adminControl2.GetUser(user);
                
            };
            if (user.role == "Auditor")
            {
                auditor = new Auditor();
                roleLabel.Text = "Auditor";
                auditorControl2.Show();
                auditorControl2.GetUser(user);
            };



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

 
        private void CreateAudit_Click(object sender, EventArgs e)
        {

        }

        private void VoterGroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void AdminControl_Load(object sender, EventArgs e)
        {

        }

        private void voterControl1_Load(object sender, EventArgs e)
        {

        }

        private void auditorControl2_Load(object sender, EventArgs e)
        {

        }

        private void adminControl2_Load(object sender, EventArgs e)
        {

        }
    }
}
