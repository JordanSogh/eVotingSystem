
namespace eVotingSystem
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginButton = new System.Windows.Forms.Button();
            this.userNameInput = new MetroFramework.Controls.MetroTextBox();
            this.passwordInput = new MetroFramework.Controls.MetroTextBox();
            this.userNameLabel = new MetroFramework.Controls.MetroLabel();
            this.passwordLabel = new MetroFramework.Controls.MetroLabel();
            this.loginFormLabel1 = new MetroFramework.Controls.MetroLabel();
            this.backgroundLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold);
            this.loginButton.Location = new System.Drawing.Point(408, 430);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(160, 46);
            this.loginButton.TabIndex = 6;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // userNameInput
            // 
            // 
            // 
            // 
            this.userNameInput.CustomButton.Image = null;
            this.userNameInput.CustomButton.Location = new System.Drawing.Point(190, 2);
            this.userNameInput.CustomButton.Name = "";
            this.userNameInput.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.userNameInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userNameInput.CustomButton.TabIndex = 1;
            this.userNameInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userNameInput.CustomButton.UseSelectable = true;
            this.userNameInput.CustomButton.Visible = false;
            this.userNameInput.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.userNameInput.Lines = new string[0];
            this.userNameInput.Location = new System.Drawing.Point(441, 265);
            this.userNameInput.MaxLength = 32767;
            this.userNameInput.Name = "userNameInput";
            this.userNameInput.PasswordChar = '\0';
            this.userNameInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userNameInput.SelectedText = "";
            this.userNameInput.SelectionLength = 0;
            this.userNameInput.SelectionStart = 0;
            this.userNameInput.ShortcutsEnabled = true;
            this.userNameInput.Size = new System.Drawing.Size(228, 40);
            this.userNameInput.TabIndex = 7;
            this.userNameInput.UseSelectable = true;
            this.userNameInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userNameInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userNameInput.Click += new System.EventHandler(this.userNameInput_Click);
            // 
            // passwordInput
            // 
            // 
            // 
            // 
            this.passwordInput.CustomButton.Image = null;
            this.passwordInput.CustomButton.Location = new System.Drawing.Point(190, 2);
            this.passwordInput.CustomButton.Name = "";
            this.passwordInput.CustomButton.Size = new System.Drawing.Size(35, 35);
            this.passwordInput.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passwordInput.CustomButton.TabIndex = 1;
            this.passwordInput.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passwordInput.CustomButton.UseSelectable = true;
            this.passwordInput.CustomButton.Visible = false;
            this.passwordInput.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.passwordInput.Lines = new string[0];
            this.passwordInput.Location = new System.Drawing.Point(441, 321);
            this.passwordInput.MaxLength = 32767;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '●';
            this.passwordInput.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passwordInput.SelectedText = "";
            this.passwordInput.SelectionLength = 0;
            this.passwordInput.SelectionStart = 0;
            this.passwordInput.ShortcutsEnabled = true;
            this.passwordInput.Size = new System.Drawing.Size(228, 40);
            this.passwordInput.TabIndex = 8;
            this.passwordInput.UseSelectable = true;
            this.passwordInput.UseSystemPasswordChar = true;
            this.passwordInput.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passwordInput.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.passwordInput.Click += new System.EventHandler(this.passwordInput_Click);
            // 
            // userNameLabel
            // 
            this.userNameLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.userNameLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.userNameLabel.Location = new System.Drawing.Point(283, 265);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(143, 40);
            this.userNameLabel.TabIndex = 9;
            this.userNameLabel.Text = "Username";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameLabel.Click += new System.EventHandler(this.userNameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.passwordLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.passwordLabel.Location = new System.Drawing.Point(283, 321);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(143, 40);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            this.passwordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.passwordLabel.Click += new System.EventHandler(this.passwordLabel_Click);
            // 
            // loginFormLabel1
            // 
            this.loginFormLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.loginFormLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.loginFormLabel1.Location = new System.Drawing.Point(259, 192);
            this.loginFormLabel1.Name = "loginFormLabel1";
            this.loginFormLabel1.Size = new System.Drawing.Size(449, 40);
            this.loginFormLabel1.TabIndex = 11;
            this.loginFormLabel1.Text = "Please Enter Your Login Details";
            this.loginFormLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundLabel
            // 
            this.backgroundLabel.BackColor = System.Drawing.Color.White;
            this.backgroundLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.backgroundLabel.Location = new System.Drawing.Point(230, 180);
            this.backgroundLabel.Name = "backgroundLabel";
            this.backgroundLabel.Size = new System.Drawing.Size(514, 346);
            this.backgroundLabel.TabIndex = 12;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(982, 602);
            this.Controls.Add(this.loginFormLabel1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.passwordInput);
            this.Controls.Add(this.userNameInput);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.backgroundLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "LoginForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 16);
            this.Resizable = false;
            this.Text = "eVotingSystemJS";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loginButton;
        private MetroFramework.Controls.MetroTextBox userNameInput;
        private MetroFramework.Controls.MetroTextBox passwordInput;
        private MetroFramework.Controls.MetroLabel userNameLabel;
        private MetroFramework.Controls.MetroLabel passwordLabel;
        private MetroFramework.Controls.MetroLabel loginFormLabel1;
        private System.Windows.Forms.Label backgroundLabel;
    }
}

