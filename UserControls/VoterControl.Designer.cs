
namespace eVotingSystem.UserControls
{
    partial class VoterControl
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
            this.VoteButton = new MetroFramework.Controls.MetroButton();
            this.campaignLabel = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // VoteButton
            // 
            this.VoteButton.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.VoteButton.Location = new System.Drawing.Point(574, 450);
            this.VoteButton.Name = "VoteButton";
            this.VoteButton.Size = new System.Drawing.Size(197, 83);
            this.VoteButton.TabIndex = 3;
            this.VoteButton.Text = "Vote";
            this.VoteButton.UseSelectable = true;
            this.VoteButton.Click += new System.EventHandler(this.VoteButton_Click);
            // 
            // campaignLabel
            // 
            this.campaignLabel.AutoSize = true;
            this.campaignLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.campaignLabel.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.campaignLabel.Location = new System.Drawing.Point(574, 96);
            this.campaignLabel.Name = "campaignLabel";
            this.campaignLabel.Size = new System.Drawing.Size(197, 25);
            this.campaignLabel.TabIndex = 4;
            this.campaignLabel.Text = "No Current Campaign";
            // 
            // VoterControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.campaignLabel);
            this.Controls.Add(this.VoteButton);
            this.Name = "VoterControl";
            this.Size = new System.Drawing.Size(1354, 687);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton VoteButton;
        private MetroFramework.Controls.MetroLabel campaignLabel;
    }
}
