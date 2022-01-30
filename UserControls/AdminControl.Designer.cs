
namespace eVotingSystem.UserControls
{
    partial class AdminControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CreateCampaign = new MetroFramework.Controls.MetroTile();
            this.DeleteUser = new MetroFramework.Controls.MetroTile();
            this.DeleteCampaign = new MetroFramework.Controls.MetroTile();
            this.UpdateUser = new MetroFramework.Controls.MetroTile();
            this.CreateUser = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // CreateCampaign
            // 
            this.CreateCampaign.ActiveControl = null;
            this.CreateCampaign.Location = new System.Drawing.Point(480, 231);
            this.CreateCampaign.Name = "CreateCampaign";
            this.CreateCampaign.Size = new System.Drawing.Size(137, 99);
            this.CreateCampaign.TabIndex = 11;
            this.CreateCampaign.Text = "Create Campaign";
            this.CreateCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateCampaign.UseSelectable = true;
            this.CreateCampaign.Click += new System.EventHandler(this.CreateCampaign_Click);
            // 
            // DeleteUser
            // 
            this.DeleteUser.ActiveControl = null;
            this.DeleteUser.Location = new System.Drawing.Point(215, 395);
            this.DeleteUser.Name = "DeleteUser";
            this.DeleteUser.Size = new System.Drawing.Size(137, 99);
            this.DeleteUser.TabIndex = 9;
            this.DeleteUser.Text = "Delete";
            this.DeleteUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteUser.UseSelectable = true;
            this.DeleteUser.Click += new System.EventHandler(this.DeleteUser_Click);
            // 
            // DeleteCampaign
            // 
            this.DeleteCampaign.ActiveControl = null;
            this.DeleteCampaign.Location = new System.Drawing.Point(215, 231);
            this.DeleteCampaign.Name = "DeleteCampaign";
            this.DeleteCampaign.Size = new System.Drawing.Size(137, 99);
            this.DeleteCampaign.TabIndex = 12;
            this.DeleteCampaign.Text = "Delete Campaign";
            this.DeleteCampaign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteCampaign.UseSelectable = true;
            this.DeleteCampaign.Click += new System.EventHandler(this.DeleteCampaign_Click);
            // 
            // UpdateUser
            // 
            this.UpdateUser.ActiveControl = null;
            this.UpdateUser.Location = new System.Drawing.Point(407, 395);
            this.UpdateUser.Name = "UpdateUser";
            this.UpdateUser.Size = new System.Drawing.Size(137, 99);
            this.UpdateUser.TabIndex = 10;
            this.UpdateUser.Text = "Update";
            this.UpdateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpdateUser.UseSelectable = true;
            this.UpdateUser.Click += new System.EventHandler(this.UpdateUser_Click);
            // 
            // CreateUser
            // 
            this.CreateUser.ActiveControl = null;
            this.CreateUser.Location = new System.Drawing.Point(604, 395);
            this.CreateUser.Name = "CreateUser";
            this.CreateUser.Size = new System.Drawing.Size(137, 99);
            this.CreateUser.TabIndex = 8;
            this.CreateUser.Text = "Create";
            this.CreateUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateUser.UseSelectable = true;
            this.CreateUser.Click += new System.EventHandler(this.CreateUser_Click);
            // 
            // AdminControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CreateCampaign);
            this.Controls.Add(this.DeleteUser);
            this.Controls.Add(this.DeleteCampaign);
            this.Controls.Add(this.UpdateUser);
            this.Controls.Add(this.CreateUser);
            this.Name = "AdminControl";
            this.Size = new System.Drawing.Size(956, 725);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile CreateCampaign;
        private MetroFramework.Controls.MetroTile DeleteUser;
        private MetroFramework.Controls.MetroTile DeleteCampaign;
        private MetroFramework.Controls.MetroTile UpdateUser;
        private MetroFramework.Controls.MetroTile CreateUser;
    }
}
