using MetroFramework.Forms;
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
    public partial class MainForm : MetroForm
    {
        private LoginUser PassedUserDetails;
        private LoginForm PassedLoginForm;
        private int optionSelected = -1;

        private Voter voter;
        private Admin admin;
        private Auditor auditor;

        private CheckBox[] checkboxes;

        private List<string> voteOptionslistToAdd = new List<string>();


        Campaign campaign;
        public MainForm(LoginUser passedDetails, LoginForm loginForm)
        {
            InitializeComponent();
            PassedUserDetails = passedDetails;
            PassedLoginForm = loginForm;
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
            else if (PassedUserDetails.Role == "Auditor")
            {
                auditor = new Auditor();
                campaign = auditor.getCurrentCampaign();
                roleLabel.Text = "Auditor";
                RenderAuditorUI();
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
            if (!voter.hasAlreadyVoted(PassedUserDetails.UserName)) {
                RenderDynamicOptions();
            }
            else
            {
                userAlreadyVotedLabel.Show();
                VoteButton.Hide();
                logOutButton.Show();
            }
            PopulateCampaign();
            voterPanel.Visible = true;

        }
        private void RenderAdminUI()
        {
            PopulateCampaign();
            adminPanel.Visible = true;
            logOutButton.Show();
        }
        private void RenderAuditorUI()
        {
            PopulateCampaign();
            auditorPanel.Visible = true;
            logOutButton.Show();
            PopulateCampaignsListBox();
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
                noCampaignVotesLabel.Location = new Point(580, 150);
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

            var findCheckboxNum = Array.FindIndex(checkboxes, c => c == checkbox);

            if (checkboxes[findCheckboxNum].Checked)
            {
                optionSelected = Convert.ToInt32(findCheckboxNum);

            }
            else
            {
                optionSelected = -1;
            }


        }
        private void VoteButton_Click(object sender, EventArgs e)
        {
            string optionDescription = "";


            if (optionSelected != -1 && !voter.hasAlreadyVoted(PassedUserDetails.UserName))
            {
                List<string> voteOptionslist = campaign.GetCampaignVoteOptionsCampaign();
                optionDescription = voteOptionslist[optionSelected];
                voter.Vote(optionSelected, campaign.Name, PassedUserDetails.UserName, PassedUserDetails.Password, optionDescription);
                foreach (CheckBox c in checkboxes)
                {
                    c.Hide();
                }
                userAlreadyVotedLabel.Text = "Thank you for Voting";
                userAlreadyVotedLabel.Show();
                VoteButton.Hide();
                logOutButton.Show();
            }
            else
            {
                MessageBox.Show("Please Select a Voting Option");
            }
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
        private void mainForm_Closing(Object senderm, FormClosingEventArgs e)
        {
            // Developmetn





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
            createCampaignButton();
        }
        private void completeCreateCampaign_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void completeAddUser_Click(object sender, EventArgs e)
        {

            if (usernameTextbox.Text != "" && passwordTextbox.Text != "" && roleTextbox.Text != "")
            {
                if (roleTextbox.Text == "Voter" || roleTextbox.Text == "Admin" || roleTextbox.Text == "Auditor")
                {


                    admin.CreateUser(usernameTextbox.Text, passwordTextbox.Text, roleTextbox.Text);
                    createUserPanel.Visible = false;
                }
                else
                {
                    MessageBox.Show("Please provide role as either Voter, Admin or Auditor");
                }
            }
            else
            {
                MessageBox.Show("Please fill in the relevant fields");
            }



        }

        private void deleteUserPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void completeDeleteUser_Click(object sender, EventArgs e)
        {
            admin.DeleteUser(deleteUsernameTextbox.Text);
            deleteUserPanel.Visible = false;
            deleteUsernameTextbox.Text = "";
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

        private void voteOptionTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void createCampaignVotes_Click(object sender, EventArgs e)
        {
            createCampaignButton();
        }

        private void createCampaignButton()
        {
            if (campaignNameTextbox.Text != "" && campaignLengthTextbox.Text != "" && voteOptionsListbox.Items.Count > 1)
            {
                admin.CreateNewCampaign(campaignNameTextbox.Text.ToString(), Convert.ToInt32(campaignLengthTextbox.Text));
                admin.CreateNewCampaignOptions(voteOptionslistToAdd, campaignNameTextbox.Text);
                campaign = admin.getCurrentCampaign();
                PopulateCampaign();
                createNewCampaignPanel.Visible = false;
                campaignNameTextbox.Text = "";
                campaignLengthTextbox.Text = "";
                voteOptionsListbox.Items.Clear();
            }
            else
            {
                MessageBox.Show("Please Fill Campaign Name and Length. Then create ballot options (minimum 2).");
            }


        }

        private void voteOptionsListbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void addVoteOptionToList()
        {
            if (voteOptionTextbox.Text != "")
            {
                voteOptionslistToAdd.Add(voteOptionTextbox.Text);
                voteOptionsListbox.Items.Add(voteOptionTextbox.Text);
                voteOptionTextbox.Text = "";
            }
        }

        private void addVoteOptionButton_Click(object sender, EventArgs e)
        {
            addVoteOptionToList();
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            PassedLoginForm.Show();
        }

        private void PopulateCampaignsListBox()
        {
            List<string> allCampaignslist = auditor.GetAllCampaigns();

            foreach (string c in allCampaignslist)
            {
                selectCampaignAuditListBox.Items.Add(c);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {


            allVotesCountListBox.Items.Clear();
            if (selectCampaignAuditListBox.SelectedItem != null)
            {

                totalVotesDisplayLabel.Text = auditor.CountAllVotes(selectCampaignAuditListBox.SelectedItem.ToString()).ToString();
                winnerDisplayLabel.Text = auditor.CalculateWinner(selectCampaignAuditListBox.SelectedItem.ToString());
                
                foreach (string c in auditor.CalculateOrder(selectCampaignAuditListBox.SelectedItem.ToString()))
                {
                    allVotesCountListBox.Items.Add(c);
                }
            }
            else
            {
                MessageBox.Show("Please Select a Campaign to Audit");
            }
        }

        private void totalVotesDisplayLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }
    }
    }
 
    

