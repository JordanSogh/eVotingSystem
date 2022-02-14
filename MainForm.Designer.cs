
using System.Windows.Forms;

namespace eVotingSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.roleLabel = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.campaignLabel = new MetroFramework.Controls.MetroLabel();
            this.VoteButton = new MetroFramework.Controls.MetroButton();
            this.voterPanel = new System.Windows.Forms.Panel();
            this.userAlreadyVotedLabel = new System.Windows.Forms.Label();
            this.logOutButton = new MetroFramework.Controls.MetroButton();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.createCampaign = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.createNewCampaignPanel = new System.Windows.Forms.Panel();
            this.clearButton = new System.Windows.Forms.Button();
            this.addVoteOptionButton = new System.Windows.Forms.Button();
            this.voteOptionsListbox = new System.Windows.Forms.ListBox();
            this.voteOptionTextbox = new System.Windows.Forms.TextBox();
            this.voteOption = new System.Windows.Forms.Label();
            this.createCampaignVotes = new System.Windows.Forms.Button();
            this.campaignLengthLabel = new System.Windows.Forms.Label();
            this.campaignLengthTextbox = new System.Windows.Forms.TextBox();
            this.campaignNameTextbox = new System.Windows.Forms.TextBox();
            this.campaignNameLabel = new System.Windows.Forms.Label();
            this.createUserPanel = new System.Windows.Forms.Panel();
            this.completeAddUser = new System.Windows.Forms.Button();
            this.roleTextbox = new System.Windows.Forms.TextBox();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.roleLabel2 = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.deleteUserPanel = new System.Windows.Forms.Panel();
            this.completeDeleteUser = new System.Windows.Forms.Button();
            this.deleteUsernameTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.auditorPanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.totalVotesLabel = new System.Windows.Forms.Label();
            this.winnerLabel = new System.Windows.Forms.Label();
            this.winnerDisplayLabel = new System.Windows.Forms.Label();
            this.totalVotesDisplayLabel = new System.Windows.Forms.Label();
            this.allVotesCountListBox = new System.Windows.Forms.ListBox();
            this.selectCampaignAuditListBox = new System.Windows.Forms.ListBox();
            this.goAuditButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.voterPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.createNewCampaignPanel.SuspendLayout();
            this.createUserPanel.SuspendLayout();
            this.deleteUserPanel.SuspendLayout();
            this.auditorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.roleLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.roleLabel.Location = new System.Drawing.Point(1110, 26);
            this.roleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(193, 46);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Default";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roleLabel.Click += new System.EventHandler(this.roleLabel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(941, 26);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(161, 46);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Logged in as:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // campaignLabel
            // 
            this.campaignLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.campaignLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.campaignLabel.Location = new System.Drawing.Point(571, 16);
            this.campaignLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.campaignLabel.Name = "campaignLabel";
            this.campaignLabel.Size = new System.Drawing.Size(386, 66);
            this.campaignLabel.TabIndex = 5;
            this.campaignLabel.Text = "None";
            this.campaignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campaignLabel.Click += new System.EventHandler(this.campaignLabel_Click);
            // 
            // VoteButton
            // 
            this.VoteButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.VoteButton.Location = new System.Drawing.Point(517, 456);
            this.VoteButton.Margin = new System.Windows.Forms.Padding(4);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(263, 81);
            this.VoteButton.TabIndex = 6;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseSelectable = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // voterPanel
            // 
            this.voterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.voterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.voterPanel.Controls.Add(this.userAlreadyVotedLabel);
            this.voterPanel.Controls.Add(this.VoteButton);
            this.voterPanel.Location = new System.Drawing.Point(73, 120);
            this.voterPanel.Margin = new System.Windows.Forms.Padding(4);
            this.voterPanel.Name = "voterPanel";
            this.voterPanel.Size = new System.Drawing.Size(1283, 558);
            this.voterPanel.TabIndex = 7;
            this.voterPanel.Visible = false;
            this.voterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.voterPanel_Paint);
            // 
            // userAlreadyVotedLabel
            // 
            this.userAlreadyVotedLabel.AutoSize = true;
            this.userAlreadyVotedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userAlreadyVotedLabel.Location = new System.Drawing.Point(466, 233);
            this.userAlreadyVotedLabel.Name = "userAlreadyVotedLabel";
            this.userAlreadyVotedLabel.Size = new System.Drawing.Size(359, 38);
            this.userAlreadyVotedLabel.TabIndex = 7;
            this.userAlreadyVotedLabel.Text = "User has already Voted";
            this.userAlreadyVotedLabel.Visible = false;
            // 
            // logOutButton
            // 
            this.logOutButton.BackColor = System.Drawing.Color.Silver;
            this.logOutButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.logOutButton.Location = new System.Drawing.Point(1204, 686);
            this.logOutButton.Margin = new System.Windows.Forms.Padding(4);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(222, 50);
            this.logOutButton.TabIndex = 8;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseSelectable = true;
            this.logOutButton.Visible = false;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.adminPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPanel.Controls.Add(this.createCampaign);
            this.adminPanel.Controls.Add(this.deleteUser);
            this.adminPanel.Controls.Add(this.addUser);
            this.adminPanel.Controls.Add(this.createNewCampaignPanel);
            this.adminPanel.Controls.Add(this.createUserPanel);
            this.adminPanel.Controls.Add(this.deleteUserPanel);
            this.adminPanel.Location = new System.Drawing.Point(67, 120);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1303, 558);
            this.adminPanel.TabIndex = 8;
            this.adminPanel.Visible = false;
            this.adminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminPanel_Paint);
            // 
            // createCampaign
            // 
            this.createCampaign.BackColor = System.Drawing.Color.Silver;
            this.createCampaign.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCampaign.Location = new System.Drawing.Point(91, 238);
            this.createCampaign.Margin = new System.Windows.Forms.Padding(4);
            this.createCampaign.Name = "createCampaign";
            this.createCampaign.Size = new System.Drawing.Size(201, 81);
            this.createCampaign.TabIndex = 8;
            this.createCampaign.Text = "Create New Campaign";
            this.createCampaign.UseVisualStyleBackColor = false;
            this.createCampaign.Click += new System.EventHandler(this.createCampaign_Click_1);
            // 
            // deleteUser
            // 
            this.deleteUser.BackColor = System.Drawing.Color.Silver;
            this.deleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUser.Location = new System.Drawing.Point(91, 133);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(201, 81);
            this.deleteUser.TabIndex = 7;
            this.deleteUser.Text = "Delete User";
            this.deleteUser.UseVisualStyleBackColor = false;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click_1);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Silver;
            this.addUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addUser.Location = new System.Drawing.Point(91, 26);
            this.addUser.Margin = new System.Windows.Forms.Padding(4);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(201, 81);
            this.addUser.TabIndex = 6;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = false;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // createNewCampaignPanel
            // 
            this.createNewCampaignPanel.Controls.Add(this.clearButton);
            this.createNewCampaignPanel.Controls.Add(this.addVoteOptionButton);
            this.createNewCampaignPanel.Controls.Add(this.voteOptionsListbox);
            this.createNewCampaignPanel.Controls.Add(this.voteOptionTextbox);
            this.createNewCampaignPanel.Controls.Add(this.voteOption);
            this.createNewCampaignPanel.Controls.Add(this.createCampaignVotes);
            this.createNewCampaignPanel.Controls.Add(this.campaignLengthLabel);
            this.createNewCampaignPanel.Controls.Add(this.campaignLengthTextbox);
            this.createNewCampaignPanel.Controls.Add(this.campaignNameTextbox);
            this.createNewCampaignPanel.Controls.Add(this.campaignNameLabel);
            this.createNewCampaignPanel.Location = new System.Drawing.Point(355, 42);
            this.createNewCampaignPanel.Margin = new System.Windows.Forms.Padding(4);
            this.createNewCampaignPanel.Name = "createNewCampaignPanel";
            this.createNewCampaignPanel.Size = new System.Drawing.Size(594, 479);
            this.createNewCampaignPanel.TabIndex = 10;
            this.createNewCampaignPanel.Visible = false;
            this.createNewCampaignPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createNewCampaignPanel_Paint);
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.Color.Silver;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(24, 432);
            this.clearButton.Margin = new System.Windows.Forms.Padding(4);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(136, 28);
            this.clearButton.TabIndex = 19;
            this.clearButton.Text = "Clear Options";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // addVoteOptionButton
            // 
            this.addVoteOptionButton.BackColor = System.Drawing.Color.Silver;
            this.addVoteOptionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVoteOptionButton.Location = new System.Drawing.Point(287, 212);
            this.addVoteOptionButton.Margin = new System.Windows.Forms.Padding(4);
            this.addVoteOptionButton.Name = "addVoteOptionButton";
            this.addVoteOptionButton.Size = new System.Drawing.Size(219, 41);
            this.addVoteOptionButton.TabIndex = 18;
            this.addVoteOptionButton.Text = "Add Vote Option";
            this.addVoteOptionButton.UseVisualStyleBackColor = false;
            this.addVoteOptionButton.Click += new System.EventHandler(this.addVoteOptionButton_Click);
            // 
            // voteOptionsListbox
            // 
            this.voteOptionsListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteOptionsListbox.FormattingEnabled = true;
            this.voteOptionsListbox.ItemHeight = 20;
            this.voteOptionsListbox.Location = new System.Drawing.Point(20, 261);
            this.voteOptionsListbox.Name = "voteOptionsListbox";
            this.voteOptionsListbox.Size = new System.Drawing.Size(255, 164);
            this.voteOptionsListbox.TabIndex = 17;
            this.voteOptionsListbox.SelectedIndexChanged += new System.EventHandler(this.voteOptionsListbox_SelectedIndexChanged);
            // 
            // voteOptionTextbox
            // 
            this.voteOptionTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteOptionTextbox.Location = new System.Drawing.Point(20, 219);
            this.voteOptionTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.voteOptionTextbox.Name = "voteOptionTextbox";
            this.voteOptionTextbox.Size = new System.Drawing.Size(255, 28);
            this.voteOptionTextbox.TabIndex = 16;
            this.voteOptionTextbox.TextChanged += new System.EventHandler(this.voteOptionTextbox_TextChanged);
            // 
            // voteOption
            // 
            this.voteOption.AutoSize = true;
            this.voteOption.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voteOption.Location = new System.Drawing.Point(20, 184);
            this.voteOption.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.voteOption.Name = "voteOption";
            this.voteOption.Size = new System.Drawing.Size(188, 24);
            this.voteOption.TabIndex = 15;
            this.voteOption.Text = "Vote Option (10 Max)";
            // 
            // createCampaignVotes
            // 
            this.createCampaignVotes.BackColor = System.Drawing.Color.Silver;
            this.createCampaignVotes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCampaignVotes.Location = new System.Drawing.Point(362, 414);
            this.createCampaignVotes.Margin = new System.Windows.Forms.Padding(4);
            this.createCampaignVotes.Name = "createCampaignVotes";
            this.createCampaignVotes.Size = new System.Drawing.Size(219, 41);
            this.createCampaignVotes.TabIndex = 14;
            this.createCampaignVotes.Text = "Create Campaign";
            this.createCampaignVotes.UseVisualStyleBackColor = false;
            this.createCampaignVotes.Click += new System.EventHandler(this.createCampaignVotes_Click);
            // 
            // campaignLengthLabel
            // 
            this.campaignLengthLabel.AutoSize = true;
            this.campaignLengthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campaignLengthLabel.Location = new System.Drawing.Point(20, 91);
            this.campaignLengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.campaignLengthLabel.Name = "campaignLengthLabel";
            this.campaignLengthLabel.Size = new System.Drawing.Size(238, 24);
            this.campaignLengthLabel.TabIndex = 13;
            this.campaignLengthLabel.Text = "Campaign Length (Months)";
            // 
            // campaignLengthTextbox
            // 
            this.campaignLengthTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campaignLengthTextbox.Location = new System.Drawing.Point(21, 125);
            this.campaignLengthTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.campaignLengthTextbox.Name = "campaignLengthTextbox";
            this.campaignLengthTextbox.Size = new System.Drawing.Size(255, 28);
            this.campaignLengthTextbox.TabIndex = 12;
            this.campaignLengthTextbox.TextChanged += new System.EventHandler(this.campaignLengthTextbox_TextChanged);
            this.campaignLengthTextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.completeCreateCampaign_KeyPress);
            // 
            // campaignNameTextbox
            // 
            this.campaignNameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campaignNameTextbox.Location = new System.Drawing.Point(21, 46);
            this.campaignNameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.campaignNameTextbox.Name = "campaignNameTextbox";
            this.campaignNameTextbox.Size = new System.Drawing.Size(255, 28);
            this.campaignNameTextbox.TabIndex = 3;
            this.campaignNameTextbox.TextChanged += new System.EventHandler(this.campaignNameTextbox_TextChanged);
            // 
            // campaignNameLabel
            // 
            this.campaignNameLabel.AutoSize = true;
            this.campaignNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.campaignNameLabel.Location = new System.Drawing.Point(17, 14);
            this.campaignNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.campaignNameLabel.Name = "campaignNameLabel";
            this.campaignNameLabel.Size = new System.Drawing.Size(152, 24);
            this.campaignNameLabel.TabIndex = 0;
            this.campaignNameLabel.Text = "Campaign Name";
            // 
            // createUserPanel
            // 
            this.createUserPanel.Controls.Add(this.completeAddUser);
            this.createUserPanel.Controls.Add(this.roleTextbox);
            this.createUserPanel.Controls.Add(this.passwordTextbox);
            this.createUserPanel.Controls.Add(this.usernameTextbox);
            this.createUserPanel.Controls.Add(this.roleLabel2);
            this.createUserPanel.Controls.Add(this.passwordLabel);
            this.createUserPanel.Controls.Add(this.usernameLabel);
            this.createUserPanel.Location = new System.Drawing.Point(351, 42);
            this.createUserPanel.Margin = new System.Windows.Forms.Padding(4);
            this.createUserPanel.Name = "createUserPanel";
            this.createUserPanel.Size = new System.Drawing.Size(379, 320);
            this.createUserPanel.TabIndex = 9;
            this.createUserPanel.Visible = false;
            this.createUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createUserPanel_Paint);
            // 
            // completeAddUser
            // 
            this.completeAddUser.BackColor = System.Drawing.Color.Silver;
            this.completeAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeAddUser.Location = new System.Drawing.Point(211, 265);
            this.completeAddUser.Margin = new System.Windows.Forms.Padding(4);
            this.completeAddUser.Name = "completeAddUser";
            this.completeAddUser.Size = new System.Drawing.Size(157, 41);
            this.completeAddUser.TabIndex = 12;
            this.completeAddUser.Text = "Add User";
            this.completeAddUser.UseVisualStyleBackColor = false;
            this.completeAddUser.Click += new System.EventHandler(this.completeAddUser_Click);
            // 
            // roleTextbox
            // 
            this.roleTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleTextbox.Location = new System.Drawing.Point(28, 222);
            this.roleTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.roleTextbox.Name = "roleTextbox";
            this.roleTextbox.Size = new System.Drawing.Size(255, 28);
            this.roleTextbox.TabIndex = 5;
            this.roleTextbox.TextChanged += new System.EventHandler(this.roleTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextbox.Location = new System.Drawing.Point(28, 130);
            this.passwordTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(255, 28);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextbox.Location = new System.Drawing.Point(28, 53);
            this.usernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(255, 28);
            this.usernameTextbox.TabIndex = 3;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // roleLabel2
            // 
            this.roleLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roleLabel2.Location = new System.Drawing.Point(24, 180);
            this.roleLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.roleLabel2.Name = "roleLabel2";
            this.roleLabel2.Size = new System.Drawing.Size(329, 26);
            this.roleLabel2.TabIndex = 2;
            this.roleLabel2.Text = "Role e.g. Voter, Admin or Auditor";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(24, 103);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(92, 24);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.Location = new System.Drawing.Point(24, 21);
            this.usernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(100, 24);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "UserName";
            // 
            // deleteUserPanel
            // 
            this.deleteUserPanel.Controls.Add(this.completeDeleteUser);
            this.deleteUserPanel.Controls.Add(this.deleteUsernameTextbox);
            this.deleteUserPanel.Controls.Add(this.label3);
            this.deleteUserPanel.Location = new System.Drawing.Point(347, 42);
            this.deleteUserPanel.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUserPanel.Name = "deleteUserPanel";
            this.deleteUserPanel.Size = new System.Drawing.Size(300, 229);
            this.deleteUserPanel.TabIndex = 10;
            this.deleteUserPanel.Visible = false;
            this.deleteUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.deleteUserPanel_Paint);
            // 
            // completeDeleteUser
            // 
            this.completeDeleteUser.BackColor = System.Drawing.Color.Silver;
            this.completeDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.completeDeleteUser.Location = new System.Drawing.Point(95, 172);
            this.completeDeleteUser.Margin = new System.Windows.Forms.Padding(4);
            this.completeDeleteUser.Name = "completeDeleteUser";
            this.completeDeleteUser.Size = new System.Drawing.Size(184, 41);
            this.completeDeleteUser.TabIndex = 14;
            this.completeDeleteUser.Text = "Delete User";
            this.completeDeleteUser.UseVisualStyleBackColor = false;
            this.completeDeleteUser.Click += new System.EventHandler(this.completeDeleteUser_Click);
            // 
            // deleteUsernameTextbox
            // 
            this.deleteUsernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUsernameTextbox.Location = new System.Drawing.Point(24, 46);
            this.deleteUsernameTextbox.Margin = new System.Windows.Forms.Padding(4);
            this.deleteUsernameTextbox.Name = "deleteUsernameTextbox";
            this.deleteUsernameTextbox.Size = new System.Drawing.Size(255, 28);
            this.deleteUsernameTextbox.TabIndex = 3;
            this.deleteUsernameTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserName";
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(342, 16);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(221, 66);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Active Campaign:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // auditorPanel
            // 
            this.auditorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.auditorPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.auditorPanel.Controls.Add(this.label6);
            this.auditorPanel.Controls.Add(this.label5);
            this.auditorPanel.Controls.Add(this.label2);
            this.auditorPanel.Controls.Add(this.totalVotesLabel);
            this.auditorPanel.Controls.Add(this.winnerLabel);
            this.auditorPanel.Controls.Add(this.winnerDisplayLabel);
            this.auditorPanel.Controls.Add(this.totalVotesDisplayLabel);
            this.auditorPanel.Controls.Add(this.allVotesCountListBox);
            this.auditorPanel.Controls.Add(this.selectCampaignAuditListBox);
            this.auditorPanel.Controls.Add(this.goAuditButton);
            this.auditorPanel.Controls.Add(this.label4);
            this.auditorPanel.Controls.Add(this.label7);
            this.auditorPanel.Controls.Add(this.label1);
            this.auditorPanel.Location = new System.Drawing.Point(79, 119);
            this.auditorPanel.Margin = new System.Windows.Forms.Padding(4);
            this.auditorPanel.Name = "auditorPanel";
            this.auditorPanel.Size = new System.Drawing.Size(1248, 559);
            this.auditorPanel.TabIndex = 11;
            this.auditorPanel.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(588, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(283, 29);
            this.label6.TabIndex = 13;
            this.label6.Text = "Total Votes Per Vote Option";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Font = new System.Drawing.Font("Calibri Light", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(365, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Select Campaign to Audit";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label2
            // 
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "Campaigns";
            // 
            // totalVotesLabel
            // 
            this.totalVotesLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVotesLabel.Location = new System.Drawing.Point(651, 172);
            this.totalVotesLabel.Name = "totalVotesLabel";
            this.totalVotesLabel.Size = new System.Drawing.Size(198, 29);
            this.totalVotesLabel.TabIndex = 8;
            this.totalVotesLabel.Text = "Total Votes In Campaign";
            // 
            // winnerLabel
            // 
            this.winnerLabel.AutoSize = true;
            this.winnerLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.winnerLabel.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerLabel.Location = new System.Drawing.Point(651, 125);
            this.winnerLabel.Name = "winnerLabel";
            this.winnerLabel.Size = new System.Drawing.Size(88, 29);
            this.winnerLabel.TabIndex = 7;
            this.winnerLabel.Text = "Winner";
            // 
            // winnerDisplayLabel
            // 
            this.winnerDisplayLabel.AutoSize = true;
            this.winnerDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winnerDisplayLabel.Location = new System.Drawing.Point(745, 123);
            this.winnerDisplayLabel.Name = "winnerDisplayLabel";
            this.winnerDisplayLabel.Size = new System.Drawing.Size(0, 29);
            this.winnerDisplayLabel.TabIndex = 6;
            this.winnerDisplayLabel.Click += new System.EventHandler(this.winnerDisplayLabel_Click);
            // 
            // totalVotesDisplayLabel
            // 
            this.totalVotesDisplayLabel.AutoSize = true;
            this.totalVotesDisplayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVotesDisplayLabel.Location = new System.Drawing.Point(855, 171);
            this.totalVotesDisplayLabel.Name = "totalVotesDisplayLabel";
            this.totalVotesDisplayLabel.Size = new System.Drawing.Size(0, 29);
            this.totalVotesDisplayLabel.TabIndex = 5;
            // 
            // allVotesCountListBox
            // 
            this.allVotesCountListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allVotesCountListBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.allVotesCountListBox.FormattingEnabled = true;
            this.allVotesCountListBox.ItemHeight = 29;
            this.allVotesCountListBox.Location = new System.Drawing.Point(593, 255);
            this.allVotesCountListBox.Name = "allVotesCountListBox";
            this.allVotesCountListBox.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.allVotesCountListBox.Size = new System.Drawing.Size(545, 265);
            this.allVotesCountListBox.TabIndex = 4;
            // 
            // selectCampaignAuditListBox
            // 
            this.selectCampaignAuditListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectCampaignAuditListBox.FormattingEnabled = true;
            this.selectCampaignAuditListBox.ItemHeight = 29;
            this.selectCampaignAuditListBox.Location = new System.Drawing.Point(36, 88);
            this.selectCampaignAuditListBox.Name = "selectCampaignAuditListBox";
            this.selectCampaignAuditListBox.Size = new System.Drawing.Size(283, 439);
            this.selectCampaignAuditListBox.TabIndex = 1;
            // 
            // goAuditButton
            // 
            this.goAuditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goAuditButton.Location = new System.Drawing.Point(359, 88);
            this.goAuditButton.Name = "goAuditButton";
            this.goAuditButton.Size = new System.Drawing.Size(177, 36);
            this.goAuditButton.TabIndex = 0;
            this.goAuditButton.Text = "Audit";
            this.goAuditButton.UseVisualStyleBackColor = true;
            this.goAuditButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(566, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 29);
            this.label4.TabIndex = 11;
            this.label4.Text = "Campaign Result";
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label7.Location = new System.Drawing.Point(642, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(335, 94);
            this.label7.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label1.Location = new System.Drawing.Point(571, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(593, 450);
            this.label1.TabIndex = 9;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 745);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.campaignLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.roleLabel);
            this.Controls.Add(this.auditorPanel);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.voterPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(27, 74, 27, 20);
            this.Resizable = false;
            this.Text = "eVotingSystemJS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainForm_Closing);
            this.Load += new System.EventHandler(this.LoginForm1_Load);
            this.voterPanel.ResumeLayout(false);
            this.voterPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.createNewCampaignPanel.ResumeLayout(false);
            this.createNewCampaignPanel.PerformLayout();
            this.createUserPanel.ResumeLayout(false);
            this.createUserPanel.PerformLayout();
            this.deleteUserPanel.ResumeLayout(false);
            this.deleteUserPanel.PerformLayout();
            this.auditorPanel.ResumeLayout(false);
            this.auditorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel roleLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel campaignLabel;
        private MetroFramework.Controls.MetroButton VoteButton;
        private System.Windows.Forms.Panel voterPanel;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button createCampaign;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button addUser;
        private System.Windows.Forms.Panel createUserPanel;
        private System.Windows.Forms.TextBox roleTextbox;
        private System.Windows.Forms.TextBox passwordTextbox;
        private System.Windows.Forms.TextBox usernameTextbox;
        private System.Windows.Forms.Label roleLabel2;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Panel createNewCampaignPanel;
        private System.Windows.Forms.TextBox campaignNameTextbox;
        private System.Windows.Forms.Label campaignNameLabel;
        private System.Windows.Forms.Panel deleteUserPanel;
        private System.Windows.Forms.TextBox deleteUsernameTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button completeAddUser;
        private System.Windows.Forms.Button completeDeleteUser;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label campaignLengthLabel;
        private System.Windows.Forms.TextBox campaignLengthTextbox;
        private System.Windows.Forms.TextBox voteOptionTextbox;
        private System.Windows.Forms.Label voteOption;
        private System.Windows.Forms.Button createCampaignVotes;
        private System.Windows.Forms.ListBox voteOptionsListbox;
        private System.Windows.Forms.Button addVoteOptionButton;
        private System.Windows.Forms.Label userAlreadyVotedLabel;
        private MetroFramework.Controls.MetroButton logOutButton;
        private System.Windows.Forms.Panel auditorPanel;
        private System.Windows.Forms.ListBox allVotesCountListBox;
        private System.Windows.Forms.ListBox selectCampaignAuditListBox;
        private System.Windows.Forms.Button goAuditButton;
        private Label totalVotesDisplayLabel;
        private Label totalVotesLabel;
        private Label winnerLabel;
        private Label winnerDisplayLabel;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button clearButton;
    }
}