using MetroFramework.Forms;
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
    public partial class MainForm : MetroForm
    {
        private LoginUser PassedUserDetails;

        private int optionSelected;

        Voter voter;
        Admin admin;
        Auditor auditor;

        CheckBox[] checkboxes;




        Campaign campaign;
        public MainForm(LoginUser passedDetailsC)
        {
            InitializeComponent();
            PassedUserDetails = passedDetailsC;

        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {

          

            if (PassedUserDetails.Role == "Voter")
            {
                voter = new Voter();
                campaign = voter.getCurrentCampaign();
                roleLabel.Text = "Voter";
                RenderVoterUI();

            }
            else if (PassedUserDetails.Role == "Admin")
            {
                admin = new Admin();
                roleLabel.Text = "Admin";
                campaign = admin.getCurrentCampaign();
                RenderAdminUI();
            }
            else if(PassedUserDetails.Role == "Auditor")
            {
                auditor = new Auditor();
                campaign = auditor.getCurrentCampaign();
                roleLabel.Text = "Auditor";

            };



        }

        private void roleLabel_Click(object sender, EventArgs e)
        {



        }

        private void metroButton1_Click(object sender, EventArgs e)
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

        private void RenderVoterUI()
        {
            RenderDynamicOptions();
            PopulateCampaign();
            voterPanel.Visible = true;

        }
        private void RenderAdminUI()
        {
            PopulateCampaign();
            adminPanel.Visible = true;
  
        }
        private void RenderAuditorUI()
        {

        }
        private void RenderDynamicOptions()
        {
            

            List<string> voteOptionslist = campaign.GetCampaignVoteOptionsCampaign();
            checkboxes = new CheckBox[voteOptionslist.Count()];

            if (voteOptionslist.Count() > 0)
            {
               

                int innitialpoint = 150;

                int yDistanceOffset = 30;

                for (int i = 0; i < voteOptionslist.Count; i++)
                {
                    checkboxes[i] = new CheckBox();

                    checkboxes[i].AutoSize = true;
                    innitialpoint += yDistanceOffset;
                    checkboxes[i].Text = voteOptionslist[i].ToString();
                    checkboxes[i].Location = new Point(600, innitialpoint);
                    checkboxes[i].Click += new System.EventHandler(this.choiceCheckbox_Click);
                    voterPanel.Controls.Add(checkboxes[i]);
                   
                }
            }
            else
            {
                Label noCampaignVotesLabel = new Label();
                noCampaignVotesLabel.Text = "No Campaign Votes Found";
                noCampaignVotesLabel.AutoSize = true;
                noCampaignVotesLabel.Location = new Point(580,150);
                voterPanel.Controls.Add(noCampaignVotesLabel);

            }
        }

        private void PopulateCampaign()
        {
            if (campaign != null)
            {
                campaignLabel.Text = campaign.Name;
            }
            else
            {
                campaignLabel.Text = "No Current Campaign";
            }
        }
        private void choiceCheckbox_Click(object sender, EventArgs e)
        {
            
            CheckBox checkbox = (sender as CheckBox);
            foreach (CheckBox c in checkboxes)
            {
                if (c != checkbox)
                {
                    c.Checked = false;
                } 
            }

            var findCheckboxNum= Array.FindIndex(checkboxes, c => c  == checkbox);
            optionSelected = Convert.ToInt32(findCheckboxNum);
        }
        private void VoteButton_Click(object sender, EventArgs e)
        {

            voter.Vote(1, campaign.Name, PassedUserDetails.UserName, PassedUserDetails.Password);
        }

        private void campaignLabel_Click(object sender, EventArgs e)
        {

        }

        private void voterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void addUser_Click(object sender, EventArgs e)
        {
            createUserPanel.Visible = true;
            createNewCampaignPanel.Visible = false;
            deleteUserPanel.Visible = false;
        }

        private void deleteUser_Click_1(object sender, EventArgs e)
        {
            deleteUserPanel.Visible = true;
            createUserPanel.Visible = false;
            createNewCampaignPanel.Visible = false;
        }

        private void createCampaign_Click_1(object sender, EventArgs e)
        {
            createNewCampaignPanel.Visible = true;
            createUserPanel.Visible = false;
            deleteUserPanel.Visible = false;
        }

        private void createUserPanel_Paint(object sender, PaintEventArgs e)
        {
         
        }

        private void usernameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void roleTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void campaignNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void completeCreateCampaign_Click(object sender, EventArgs e)
        {
            admin.CreateNewCampaign(campaignNameTextbox.Text, Convert.ToInt32(campaignLengthTextbox.Text));
            campaign = admin.getCurrentCampaign();
            PopulateCampaign();
            createNewCampaignPanel.Visible = false;
        }

        private void completeAddUser_Click(object sender, EventArgs e)
        {
            createUserPanel.Visible = false;

        }

        private void deleteUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void completeDeleteUser_Click(object sender, EventArgs e)
        {
            admin.DeleteUser(deleteUsernameTextbox.Text);
            deleteUserPanel.Visible = false;
        }

        private void createNewCampaignPanel_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void campaignLengthTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }
