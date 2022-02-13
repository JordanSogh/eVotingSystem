using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace eVotingSystem
{
    public partial class MainForm : MetroForm
    {
        //Information passed from LoginForm
        private LoginUser PassedUserDetails;
        private LoginForm PassedLoginForm;

        private int optionSelected = -1;

        // Instantiates Objects for each potential user.
        private Voter voter;
        private Admin admin;
        private Auditor auditor;

        //Checkboxes for Vote Options
        private CheckBox[] checkboxes;

        //List that holds Vote Options
        private List<string> voteOptionslistToAdd = new List<string>();

        //Current Campaign
        private Campaign campaign;
        public MainForm(LoginUser passedDetails, LoginForm loginForm)
        {
            InitializeComponent();
            PassedUserDetails = passedDetails;
            PassedLoginForm = loginForm;
        }

        private void LoginForm1_Load(object sender, EventArgs e)
        { 
            //Selects the User Role and loads the relevant UI
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
        private void RenderVoterUI()
        {
            //Renders Voter UI
            if (!voter.hasAlreadyVoted(PassedUserDetails.UserName))
            {
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
            //Renders Admin UI
            PopulateCampaign();
            adminPanel.Visible = true;
            logOutButton.Show();
        }
        private void RenderAuditorUI()
        {
            //Renders Auditor UI
            PopulateCampaign();
            auditorPanel.Visible = true;
            logOutButton.Show();
            PopulateCampaignsListBox();
        }
        private void RenderDynamicOptions()
        {
            //Renders Vote Options Dynamically
            if (campaign != null)
            {
                List<string> voteOptionslist = voter.GetCampaignVoteOptionsCampaign(campaign.Name);
                checkboxes = new CheckBox[voteOptionslist.Count()];

                if (voteOptionslist.Count() > 0)
                {


                    int innitialpoint = 50;

                    int yDistanceOffset = 30;

                    for (int i = 0; i < voteOptionslist.Count; i++)
                    {
                        checkboxes[i] = new CheckBox();

                        checkboxes[i].AutoSize = true;
                        innitialpoint += yDistanceOffset;
                        checkboxes[i].Text = voteOptionslist[i].ToString();
                        checkboxes[i].Location = new Point(540, innitialpoint);
                        checkboxes[i].Click += new System.EventHandler(this.choiceCheckbox_Click);
                        voterPanel.Controls.Add(checkboxes[i]);

                    }
                }
                else
                {
                    Label noCampaignVotesLabel = new Label();
                    noCampaignVotesLabel.Text = "No Campaign Votes Found";
                    noCampaignVotesLabel.AutoSize = true;
                    noCampaignVotesLabel.Location = new Point(560, 50);
                    voterPanel.Controls.Add(noCampaignVotesLabel);
                    logOutButton.Show();
                }
            }
            else
            {
                Label noCampaignVotesLabel = new Label();
                noCampaignVotesLabel.Text = "No Campaign Votes Found";
                logOutButton.Show();
            }
        }

        private void PopulateCampaign()
        {
            //Populated Campaign Label
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
            //Event on Selection of Vote Option
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
            //Event on Selection of Vote Button that creates the Vote for Voter
            string optionDescription;

            if (optionSelected != -1 && !voter.hasAlreadyVoted(PassedUserDetails.UserName))
            {
                bool voteSuccess = false;
                List<string> voteOptionslist = voter.GetCampaignVoteOptionsCampaign(campaign.Name);
                optionDescription = voteOptionslist[optionSelected];
                voteSuccess = voter.Vote(optionSelected, campaign.Name, PassedUserDetails.UserName, PassedUserDetails.Password, optionDescription);

                if (voteSuccess)
                {
                    foreach (CheckBox c in checkboxes)
                    {
                        c.Hide();
                    }
                    userAlreadyVotedLabel.Text = "Thank you for Voting";
                    userAlreadyVotedLabel.Show();
                    VoteButton.Hide();
                    logOutButton.Show();
                }
            }
            else
            {
                MessageBox.Show("Please Select a Voting Option");
            }
        }
        private void addUser_Click(object sender, EventArgs e)
        {
            //Event on Adduser button to show Add User UI
            createUserPanel.Visible = true;
            createNewCampaignPanel.Visible = false;
            deleteUserPanel.Visible = false;
        }
        private void mainForm_Closing(Object sender, FormClosingEventArgs e)
        {
            //Event on Closing of mainform. Gets whether it was closing by the X or Logout button.
            if ((sender as Form).ActiveControl.Text == "Logout")
            {
                PassedLoginForm.Show();
            }
            else
            {
                PassedLoginForm.Close();
            }
        }
        private void deleteUser_Click_1(object sender, EventArgs e)
        {
            //Event on Delete User Button that bring up delete user UI
            deleteUserPanel.Visible = true;
            createUserPanel.Visible = false;
            createNewCampaignPanel.Visible = false;
        }

        private void createCampaign_Click_1(object sender, EventArgs e)
        { 
            //Event on select of Create Campaign button that bring up create campaign UI
            createNewCampaignPanel.Visible = true;
            createUserPanel.Visible = false;
            deleteUserPanel.Visible = false;
        }
        private void completeCreateCampaign_Click(object sender, EventArgs e)
        { 
            //Event on completeCreateCampaig button that creates new Campaign.
            createCampaignButton();
        }
        private void completeCreateCampaign_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Event when input for CampaignLength textbox to ensure input is only Integer.
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void completeAddUser_Click(object sender, EventArgs e)
        {
            //Event when CompleteAddUser Button is selected that then creates the user with inputted details.
            if (usernameTextbox.Text != "" && passwordTextbox.Text != "" && roleTextbox.Text != "")
            {
                if (roleTextbox.Text == "Voter" || roleTextbox.Text == "Admin" || roleTextbox.Text == "Auditor")
                {

                    if(admin.CreateUser(usernameTextbox.Text, passwordTextbox.Text, roleTextbox.Text)){

                        createUserPanel.Visible = false;
                        MessageBox.Show(usernameTextbox.Text + "Created");
                    }
                    else
                    {
                        MessageBox.Show("Failed to Add User");
                    }
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
        private void completeDeleteUser_Click(object sender, EventArgs e)
        { 
            //Event on CompleteDeleteUser Button that deletes user stated in username input field.
            if (deleteUsernameTextbox.Text != "")
            {
                if (admin.DeleteUser(deleteUsernameTextbox.Text))
                {
                    MessageBox.Show(deleteUsernameTextbox.Text + " Deleted");
                    deleteUserPanel.Visible = false;
                    deleteUsernameTextbox.Text = "";
                }
                else
                {
                    MessageBox.Show("User not found");
                }
            }
            else
            {
                MessageBox.Show("Please Enter The Username For The User To Be Deleted");
            }
        }

        private void createCampaignVotes_Click(object sender, EventArgs e)
        { 
            //Event on Create Campaign that fires createcampaign method to create the Campaign
            createCampaignButton();
        }

        private void createCampaignButton()
        { 
            //Creates campaign using inputted textbox values. Then refreshes UI.
            if (campaignNameTextbox.Text != "" && campaignLengthTextbox.Text != "" && voteOptionsListbox.Items.Count > 1)
            {
                if (admin.CreateNewCampaign(campaignNameTextbox.Text.ToString(), Convert.ToInt32(campaignLengthTextbox.Text)) && admin.CreateNewCampaignOptions(voteOptionslistToAdd, campaignNameTextbox.Text))
                {
                    MessageBox.Show("Campaign Created Successfully");
                    campaign = admin.getCurrentCampaign();
                    PopulateCampaign();
                    createNewCampaignPanel.Visible = false;
                    campaignNameTextbox.Text = "";
                    campaignLengthTextbox.Text = "";
                    voteOptionsListbox.Items.Clear();
                }
                else
                {
                    MessageBox.Show("Create Campaign Failed");
                }

            }
            else
            {
                MessageBox.Show("Please Fill Campaign Name and Length. Then create ballot options (minimum 2).");
            }


        }

        private void addVoteOptionToList()
        {
            // Adds VoteOption textbox value to VoteOptionListbox
            if (voteOptionTextbox.Text != "")
            {
                voteOptionslistToAdd.Add(voteOptionTextbox.Text);
                voteOptionsListbox.Items.Add(voteOptionTextbox.Text);
                voteOptionTextbox.Text = "";
            }
        }

        private void addVoteOptionButton_Click(object sender, EventArgs e)
        {
            //Verifies that VoteOption listbox count is not above 10, then adds to listbox if not.
            if(voteOptionsListbox.Items.Count <= 10)
            {
                addVoteOptionToList();
            }
            else
            {
                MessageBox.Show("Maximum Number of Options Reached");
            }
          
        }

        private void logOutButton_Click(object sender, EventArgs e)
        {
            //Closes Mainform
            this.Close();
        }

        private void PopulateCampaignsListBox()
        {
            // Populates CampaignListbox with results of all Campaigns in Database
            List<string> allCampaignslist = auditor.GetAllCampaigns();

            foreach (string c in allCampaignslist)
            {
                selectCampaignAuditListBox.Items.Add(c);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Button that is used for beginning calulcations on select Campaign. Fires methods for Counting all votes and Calculating Winner.
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


        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        //*UNUSED CONTROL EVENTS     ALL ARE EMPTY*/////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        private void roleLabel_Click(object sender, EventArgs e)
        {

        }
        private void voteOptionsListbox_SelectedIndexChanged(object sender, EventArgs e)
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
        private void campaignLabel_Click(object sender, EventArgs e)
        {

        }

        private void voterPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void adminPanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void deleteUserPanel_Paint(object sender, PaintEventArgs e)
        {

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

        private void winnerDisplayLabel_Click(object sender, EventArgs e)
        {

        }
    }
    }
 
    

