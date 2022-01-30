
namespace eVotingSystem.UserControls
{
    partial class AuditorControl
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
            this.ViewAudit = new MetroFramework.Controls.MetroTile();
            this.CreateAudit = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ViewAudit
            // 
            this.ViewAudit.ActiveControl = null;
            this.ViewAudit.Location = new System.Drawing.Point(417, 217);
            this.ViewAudit.Name = "ViewAudit";
            this.ViewAudit.Size = new System.Drawing.Size(137, 99);
            this.ViewAudit.TabIndex = 11;
            this.ViewAudit.Text = "ViewAudit";
            this.ViewAudit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ViewAudit.UseSelectable = true;
            // 
            // CreateAudit
            // 
            this.CreateAudit.ActiveControl = null;
            this.CreateAudit.Location = new System.Drawing.Point(417, 367);
            this.CreateAudit.Name = "CreateAudit";
            this.CreateAudit.Size = new System.Drawing.Size(137, 99);
            this.CreateAudit.TabIndex = 10;
            this.CreateAudit.Text = "CreateAudit";
            this.CreateAudit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateAudit.UseSelectable = true;
            // 
            // AuditorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ViewAudit);
            this.Controls.Add(this.CreateAudit);
            this.Name = "AuditorControl";
            this.Size = new System.Drawing.Size(996, 694);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile ViewAudit;
        private MetroFramework.Controls.MetroTile CreateAudit;
    }
}
