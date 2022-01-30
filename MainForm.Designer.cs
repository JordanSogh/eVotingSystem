
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
            this.VoteButton = new MetroFramework.Controls.MetroButton();
            this.CreateUser = new MetroFramework.Controls.MetroTile();
            this.DeleteUser = new MetroFramework.Controls.MetroTile();
            this.CreateCampaign = new MetroFramework.Controls.MetroTile();
            this.DeleteCampaign = new MetroFramework.Controls.MetroTile();
            this.UpdateUser = new MetroFramework.Controls.MetroTile();
            this.AdminGroupBox = new System.Windows.Forms.GroupBox();
            this.VoterGroupBox = new System.Windows.Forms.GroupBox();
            this.AuditorGroupBox = new System.Windows.Forms.GroupBox();
            this.AdminGroupBox.SuspendLayout();
            this.VoterGroupBox.SuspendLayout();
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
            // VoteButton
            // 
            this.VoteButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.VoteButton.Location = new System.Drawing.Point(534, 437);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(170, 83);
            this.VoteButton.TabIndex = 2;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseSelectable = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // CreateUser
            // 
            this.CreateUser.ActiveControl = null;
            this.CreateUser.Location = new System.Drawing.Point(356, 33);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(137, 99);
            this.CreateUser.TabIndex = 3;
            this.CreateUser.Text = "Create";
            this.CreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateUser.UseSelectable = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.ActiveControl = null;
            this.DeleteUser.Location = new System.Drawing.Point(24, 33);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(137, 99);
            this.DeleteUser.TabIndex = 4;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteUser.UseSelectable = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // CreateCampaign
            // 
            this.CreateCampaign.ActiveControl = null;
            this.CreateCampaign.Location = new System.Drawing.Point(329, 386);
            this.CreateCampaign.Name = "CreateCampaign";
            this.CreateCampaign.Size = new System.Drawing.Size(137, 99);
            this.CreateCampaign.TabIndex = 6;
            this.CreateCampaign.Text = "Create Campaign";
            this.CreateCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateCampaign.UseSelectable = true;
            this.CreateCampaign.Click += new System.EventHandler(this.CreateCampaign_Click);
            // 
            // DeleteCampaign
            // 
            this.DeleteCampaign.ActiveControl = null;
            this.DeleteCampaign.Location = new System.Drawing.Point(57, 350);
            this.DeleteCampaign.Name = "DeleteCampaign";
            this.DeleteCampaign.Size = new System.Drawing.Size(137, 99);
            this.DeleteCampaign.TabIndex = 7;
            this.DeleteCampaign.Text = "Delete Campaign";
            this.DeleteCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteCampaign.UseSelectable = true;
            // 
            // UpdateUser
            // 
            this.UpdateUser.ActiveControl = null;
            this.UpdateUser.Location = new System.Drawing.Point(190, 33);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(137, 99);
            this.UpdateUser.TabIndex = 5;
            this.UpdateUser.Text = "Update";
            this.UpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateUser.UseSelectable = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // AdminGroupBox
            // 
            this.AdminGroupBox.Controls.Add(this.VoterGroupBox);
            this.AdminGroupBox.Controls.Add(this.DeleteUser);
            this.AdminGroupBox.Controls.Add(this.CreateCampaign);
            this.AdminGroupBox.Controls.Add(this.DeleteCampaign);
            this.AdminGroupBox.Controls.Add(this.UpdateUser);
            this.AdminGroupBox.Controls.Add(this.CreateUser);
            this.AdminGroupBox.Location = new System.Drawing.Point(23, 69);
            this.AdminGroupBox.Name = "AdminGroupBox";
            this.AdminGroupBox.Size = new System.Drawing.Size(1340, 548);
            this.AdminGroupBox.TabIndex = 8;
            this.AdminGroupBox.TabStop = false;
            this.AdminGroupBox.Visible = false;
            this.AdminGroupBox.Enter += new System.EventHandler(this.AdminGroupBox_Click);
            // 
            // VoterGroupBox
            // 
            this.VoterGroupBox.Controls.Add(this.VoteButton);
            this.VoterGroupBox.Controls.Add(this.AuditorGroupBox);
            this.VoterGroupBox.Location = new System.Drawing.Point(6, 0);
            this.VoterGroupBox.Name = "VoterGroupBox";
            this.VoterGroupBox.Size = new System.Drawing.Size(1334, 548);
            this.VoterGroupBox.TabIndex = 9;
            this.VoterGroupBox.TabStop = false;
            this.VoterGroupBox.Visible = false;
            this.VoterGroupBox.Enter += new System.EventHandler(this.VoterGroupBox_Enter);
            // 
            // AuditorGroupBox
            // 
            this.AuditorGroupBox.Location = new System.Drawing.Point(2, 11);
            this.AuditorGroupBox.Name = "AuditorGroupBox";
            this.AuditorGroupBox.Size = new System.Drawing.Size(1346, 548);
            this.AuditorGroupBox.TabIndex = 10;
            this.AuditorGroupBox.TabStop = false;
            this.AuditorGroupBox.Visible = false;
            this.AuditorGroupBox.Enter += new System.EventHandler(this.AuditorGroupBox_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.AdminGroupBox);
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
            this.AdminGroupBox.ResumeLayout(false);
            this.VoterGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel roleLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton VoteButton;
        private MetroFramework.Controls.MetroTile CreateUser;
        private MetroFramework.Controls.MetroTile DeleteUser;
        private MetroFramework.Controls.MetroTile CreateCampaign;
        private MetroFramework.Controls.MetroTile DeleteCampaign;
        private MetroFramework.Controls.MetroTile UpdateUser;
        private System.Windows.Forms.GroupBox AdminGroupBox;
        private System.Windows.Forms.GroupBox VoterGroupBox;
        private System.Windows.Forms.GroupBox AuditorGroupBox;
    }
}