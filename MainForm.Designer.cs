
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
            this.adminControl2 = new eVotingSystem.UserControls.AdminControl();
            this.auditorControl2 = new eVotingSystem.UserControls.AuditorControl();
            this.voterControl1 = new eVotingSystem.UserControls.VoterControl();
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
            // adminControl2
            // 
            this.adminControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adminControl2.Location = new System.Drawing.Point(33, 94);
            this.adminControl2.Name = "adminControl2";
            this.adminControl2.Size = new System.Drawing.Size(1330, 687);
            this.adminControl2.TabIndex = 12;
            this.adminControl2.Visible = false;
            this.adminControl2.Load += new System.EventHandler(this.adminControl2_Load);
            // 
            // auditorControl2
            // 
            this.auditorControl2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.auditorControl2.Location = new System.Drawing.Point(33, 94);
            this.auditorControl2.Name = "auditorControl2";
            this.auditorControl2.Size = new System.Drawing.Size(1330, 687);
            this.auditorControl2.TabIndex = 11;
            this.auditorControl2.Visible = false;
            this.auditorControl2.Load += new System.EventHandler(this.auditorControl2_Load);
            // 
            // voterControl1
            // 
            this.voterControl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.voterControl1.Location = new System.Drawing.Point(23, 94);
            this.voterControl1.Name = "voterControl1";
            this.voterControl1.Size = new System.Drawing.Size(1354, 672);
            this.voterControl1.TabIndex = 10;
            this.voterControl1.Visible = false;
            this.voterControl1.Load += new System.EventHandler(this.voterControl1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.adminControl2);
            this.Controls.Add(this.auditorControl2);
            this.Controls.Add(this.voterControl1);
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
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLabel roleLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        
    }
}