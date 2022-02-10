
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
            this.adminPanel = new System.Windows.Forms.Panel();
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
            this.createNewCampaignPanel = new System.Windows.Forms.Panel();
            this.campaignLengthLabel = new System.Windows.Forms.Label();
            this.campaignLengthTextbox = new System.Windows.Forms.TextBox();
            this.completeCreateCampaign = new System.Windows.Forms.Button();
            this.campaignNameTextbox = new System.Windows.Forms.TextBox();
            this.campaignNameLabel = new System.Windows.Forms.Label();
            this.createCampaign = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.addUser = new System.Windows.Forms.Button();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.voterPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.createUserPanel.SuspendLayout();
            this.deleteUserPanel.SuspendLayout();
            this.createNewCampaignPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // roleLabel
            // 
            this.roleLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.roleLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.roleLabel.Location = new System.Drawing.Point(1218, 29);
            this.roleLabel.Name = "roleLabel";
            this.roleLabel.Size = new System.Drawing.Size(145, 37);
            this.roleLabel.TabIndex = 0;
            this.roleLabel.Text = "Default";
            this.roleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.roleLabel.Click += new System.EventHandler(this.roleLabel_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(1081, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(131, 37);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Logged in as:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // campaignLabel
            // 
            this.campaignLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.campaignLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.campaignLabel.Location = new System.Drawing.Point(573, 60);
            this.campaignLabel.Name = "campaignLabel";
            this.campaignLabel.Size = new System.Drawing.Size(285, 54);
            this.campaignLabel.TabIndex = 5;
            this.campaignLabel.Text = "None";
            this.campaignLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.campaignLabel.Click += new System.EventHandler(this.campaignLabel_Click);
            // 
            // VoteButton
            // 
            this.VoteButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.VoteButton.Location = new System.Drawing.Point(552, 563);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(197, 83);
            this.VoteButton.TabIndex = 6;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseSelectable = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // voterPanel
            // 
            this.voterPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.voterPanel.Controls.Add(this.VoteButton);
            this.voterPanel.Location = new System.Drawing.Point(71, 117);
            this.voterPanel.Name = "voterPanel";
            this.voterPanel.Size = new System.Drawing.Size(1268, 664);
            this.voterPanel.TabIndex = 7;
            this.voterPanel.Visible = false;
            this.voterPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.voterPanel_Paint);
            // 
            // adminPanel
            // 
            this.adminPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.adminPanel.Controls.Add(this.createUserPanel);
            this.adminPanel.Controls.Add(this.deleteUserPanel);
            this.adminPanel.Controls.Add(this.createNewCampaignPanel);
            this.adminPanel.Controls.Add(this.createCampaign);
            this.adminPanel.Controls.Add(this.deleteUser);
            this.adminPanel.Controls.Add(this.addUser);
            this.adminPanel.Location = new System.Drawing.Point(51, 122);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1199, 577);
            this.adminPanel.TabIndex = 8;
            this.adminPanel.Visible = false;
            this.adminPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.adminPanel_Paint);
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
            this.createUserPanel.Location = new System.Drawing.Point(260, 102);
            this.createUserPanel.Name = "createUserPanel";
            this.createUserPanel.Size = new System.Drawing.Size(309, 260);
            this.createUserPanel.TabIndex = 9;
            this.createUserPanel.Visible = false;
            this.createUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createUserPanel_Paint);
            // 
            // completeAddUser
            // 
            this.completeAddUser.Location = new System.Drawing.Point(172, 208);
            this.completeAddUser.Name = "completeAddUser";
            this.completeAddUser.Size = new System.Drawing.Size(118, 33);
            this.completeAddUser.TabIndex = 12;
            this.completeAddUser.Text = "Add User";
            this.completeAddUser.UseVisualStyleBackColor = true;
            this.completeAddUser.Click += new System.EventHandler(this.completeAddUser_Click);
            // 
            // roleTextbox
            // 
            this.roleTextbox.Location = new System.Drawing.Point(46, 180);
            this.roleTextbox.Name = "roleTextbox";
            this.roleTextbox.Size = new System.Drawing.Size(192, 19);
            this.roleTextbox.TabIndex = 5;
            this.roleTextbox.TextChanged += new System.EventHandler(this.roleTextbox_TextChanged);
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(46, 106);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(192, 19);
            this.passwordTextbox.TabIndex = 4;
            this.passwordTextbox.TextChanged += new System.EventHandler(this.passwordTextbox_TextChanged);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Location = new System.Drawing.Point(46, 43);
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(192, 19);
            this.usernameTextbox.TabIndex = 3;
            this.usernameTextbox.TextChanged += new System.EventHandler(this.usernameTextbox_TextChanged);
            // 
            // roleLabel2
            // 
            this.roleLabel2.Location = new System.Drawing.Point(43, 146);
            this.roleLabel2.Name = "roleLabel2";
            this.roleLabel2.Size = new System.Drawing.Size(247, 21);
            this.roleLabel2.TabIndex = 2;
            this.roleLabel2.Text = "Role e.g. Voter, Admin or Auditor";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Location = new System.Drawing.Point(43, 84);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(53, 13);
            this.passwordLabel.TabIndex = 1;
            this.passwordLabel.Text = "Password";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Location = new System.Drawing.Point(43, 17);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(57, 13);
            this.usernameLabel.TabIndex = 0;
            this.usernameLabel.Text = "UserName";
            // 
            // deleteUserPanel
            // 
            this.deleteUserPanel.Controls.Add(this.completeDeleteUser);
            this.deleteUserPanel.Controls.Add(this.deleteUsernameTextbox);
            this.deleteUserPanel.Controls.Add(this.label3);
            this.deleteUserPanel.Location = new System.Drawing.Point(257, 102);
            this.deleteUserPanel.Name = "deleteUserPanel";
            this.deleteUserPanel.Size = new System.Drawing.Size(309, 186);
            this.deleteUserPanel.TabIndex = 10;
            this.deleteUserPanel.Visible = false;
            this.deleteUserPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.deleteUserPanel_Paint);
            // 
            // completeDeleteUser
            // 
            this.completeDeleteUser.Location = new System.Drawing.Point(149, 142);
            this.completeDeleteUser.Name = "completeDeleteUser";
            this.completeDeleteUser.Size = new System.Drawing.Size(138, 33);
            this.completeDeleteUser.TabIndex = 14;
            this.completeDeleteUser.Text = "Delete User";
            this.completeDeleteUser.UseVisualStyleBackColor = true;
            this.completeDeleteUser.Click += new System.EventHandler(this.completeDeleteUser_Click);
            // 
            // deleteUsernameTextbox
            // 
            this.deleteUsernameTextbox.Location = new System.Drawing.Point(46, 43);
            this.deleteUsernameTextbox.Name = "deleteUsernameTextbox";
            this.deleteUsernameTextbox.Size = new System.Drawing.Size(192, 19);
            this.deleteUsernameTextbox.TabIndex = 3;
            this.deleteUsernameTextbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "UserName";
            // 
            // createNewCampaignPanel
            // 
            this.createNewCampaignPanel.Controls.Add(this.campaignLengthLabel);
            this.createNewCampaignPanel.Controls.Add(this.campaignLengthTextbox);
            this.createNewCampaignPanel.Controls.Add(this.completeCreateCampaign);
            this.createNewCampaignPanel.Controls.Add(this.campaignNameTextbox);
            this.createNewCampaignPanel.Controls.Add(this.campaignNameLabel);
            this.createNewCampaignPanel.Location = new System.Drawing.Point(254, 109);
            this.createNewCampaignPanel.Name = "createNewCampaignPanel";
            this.createNewCampaignPanel.Size = new System.Drawing.Size(545, 152);
            this.createNewCampaignPanel.TabIndex = 10;
            this.createNewCampaignPanel.Visible = false;
            this.createNewCampaignPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.createNewCampaignPanel_Paint);
            // 
            // campaignLengthLabel
            // 
            this.campaignLengthLabel.AutoSize = true;
            this.campaignLengthLabel.Location = new System.Drawing.Point(45, 80);
            this.campaignLengthLabel.Name = "campaignLengthLabel";
            this.campaignLengthLabel.Size = new System.Drawing.Size(90, 13);
            this.campaignLengthLabel.TabIndex = 13;
            this.campaignLengthLabel.Text = "Campaign Length";
            // 
            // campaignLengthTextbox
            // 
            this.campaignLengthTextbox.Location = new System.Drawing.Point(46, 107);
            this.campaignLengthTextbox.Name = "campaignLengthTextbox";
            this.campaignLengthTextbox.Size = new System.Drawing.Size(192, 19);
            this.campaignLengthTextbox.TabIndex = 12;
            this.campaignLengthTextbox.TextChanged += new System.EventHandler(this.campaignLengthTextbox_TextChanged);
            // 
            // completeCreateCampaign
            // 
            this.completeCreateCampaign.Location = new System.Drawing.Point(329, 80);
            this.completeCreateCampaign.Name = "completeCreateCampaign";
            this.completeCreateCampaign.Size = new System.Drawing.Size(164, 33);
            this.completeCreateCampaign.TabIndex = 11;
            this.completeCreateCampaign.Text = "Create Campaign";
            this.completeCreateCampaign.UseVisualStyleBackColor = true;
            this.completeCreateCampaign.Click += new System.EventHandler(this.completeCreateCampaign_Click);
            // 
            // campaignNameTextbox
            // 
            this.campaignNameTextbox.Location = new System.Drawing.Point(46, 43);
            this.campaignNameTextbox.Name = "campaignNameTextbox";
            this.campaignNameTextbox.Size = new System.Drawing.Size(192, 19);
            this.campaignNameTextbox.TabIndex = 3;
            this.campaignNameTextbox.TextChanged += new System.EventHandler(this.campaignNameTextbox_TextChanged);
            // 
            // campaignNameLabel
            // 
            this.campaignNameLabel.AutoSize = true;
            this.campaignNameLabel.Location = new System.Drawing.Point(43, 17);
            this.campaignNameLabel.Name = "campaignNameLabel";
            this.campaignNameLabel.Size = new System.Drawing.Size(85, 13);
            this.campaignNameLabel.TabIndex = 0;
            this.campaignNameLabel.Text = "Campaign Name";
            // 
            // createCampaign
            // 
            this.createCampaign.Location = new System.Drawing.Point(80, 269);
            this.createCampaign.Name = "createCampaign";
            this.createCampaign.Size = new System.Drawing.Size(151, 66);
            this.createCampaign.TabIndex = 8;
            this.createCampaign.Text = "Create New Campaign";
            this.createCampaign.UseVisualStyleBackColor = true;
            this.createCampaign.Click += new System.EventHandler(this.createCampaign_Click_1);
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(80, 186);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(151, 66);
            this.deleteUser.TabIndex = 7;
            this.deleteUser.Text = "Delete User";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click_1);
            // 
            // addUser
            // 
            this.addUser.Location = new System.Drawing.Point(80, 102);
            this.addUser.Name = "addUser";
            this.addUser.Size = new System.Drawing.Size(151, 66);
            this.addUser.TabIndex = 6;
            this.addUser.Text = "Add User";
            this.addUser.UseVisualStyleBackColor = true;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(313, 60);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(255, 54);
            this.metroLabel2.TabIndex = 9;
            this.metroLabel2.Text = "Current Campaign:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel2.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.voterPanel);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.adminPanel);
            this.Controls.Add(this.campaignLabel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.roleLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 16);
            this.Resizable = false;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.LoginForm1_Load);
            this.voterPanel.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.createUserPanel.ResumeLayout(false);
            this.createUserPanel.PerformLayout();
            this.deleteUserPanel.ResumeLayout(false);
            this.deleteUserPanel.PerformLayout();
            this.createNewCampaignPanel.ResumeLayout(false);
            this.createNewCampaignPanel.PerformLayout();
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
        private System.Windows.Forms.Button completeCreateCampaign;
        private System.Windows.Forms.Button completeAddUser;
        private System.Windows.Forms.Button completeDeleteUser;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.Label campaignLengthLabel;
        private System.Windows.Forms.TextBox campaignLengthTextbox;
    }
}