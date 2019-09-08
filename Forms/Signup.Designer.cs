namespace Studrex.Forms
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            this.signupUsernameLabel = new System.Windows.Forms.Label();
            this.signupUsernameTextbox = new System.Windows.Forms.TextBox();
            this.signupPasswordLabel = new System.Windows.Forms.Label();
            this.signupPasswordTextbox = new System.Windows.Forms.TextBox();
            this.signupSignupButton = new System.Windows.Forms.Button();
            this.signupFirstNameLabel = new System.Windows.Forms.Label();
            this.signupFirstnameTextbox = new System.Windows.Forms.TextBox();
            this.signupLastnameLabel = new System.Windows.Forms.Label();
            this.signupLastnameTextbox = new System.Windows.Forms.TextBox();
            this.signupRoleCombobox = new System.Windows.Forms.ComboBox();
            this.signupRoleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // signupUsernameLabel
            // 
            this.signupUsernameLabel.AutoSize = true;
            this.signupUsernameLabel.Location = new System.Drawing.Point(24, 19);
            this.signupUsernameLabel.Name = "signupUsernameLabel";
            this.signupUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.signupUsernameLabel.TabIndex = 0;
            this.signupUsernameLabel.Text = "Username:";
            // 
            // signupUsernameTextbox
            // 
            this.signupUsernameTextbox.Location = new System.Drawing.Point(27, 36);
            this.signupUsernameTextbox.Name = "signupUsernameTextbox";
            this.signupUsernameTextbox.Size = new System.Drawing.Size(140, 20);
            this.signupUsernameTextbox.TabIndex = 1;
            // 
            // signupPasswordLabel
            // 
            this.signupPasswordLabel.AutoSize = true;
            this.signupPasswordLabel.Location = new System.Drawing.Point(24, 68);
            this.signupPasswordLabel.Name = "signupPasswordLabel";
            this.signupPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.signupPasswordLabel.TabIndex = 2;
            this.signupPasswordLabel.Text = "Password:";
            // 
            // signupPasswordTextbox
            // 
            this.signupPasswordTextbox.Location = new System.Drawing.Point(27, 85);
            this.signupPasswordTextbox.Name = "signupPasswordTextbox";
            this.signupPasswordTextbox.Size = new System.Drawing.Size(140, 20);
            this.signupPasswordTextbox.TabIndex = 3;
            this.signupPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // signupSignupButton
            // 
            this.signupSignupButton.Location = new System.Drawing.Point(227, 136);
            this.signupSignupButton.Name = "signupSignupButton";
            this.signupSignupButton.Size = new System.Drawing.Size(75, 23);
            this.signupSignupButton.TabIndex = 4;
            this.signupSignupButton.Text = "Sign Up";
            this.signupSignupButton.UseVisualStyleBackColor = true;
            this.signupSignupButton.Click += new System.EventHandler(this.SignupSignupButton_Click);
            // 
            // signupFirstNameLabel
            // 
            this.signupFirstNameLabel.AutoSize = true;
            this.signupFirstNameLabel.Location = new System.Drawing.Point(188, 19);
            this.signupFirstNameLabel.Name = "signupFirstNameLabel";
            this.signupFirstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.signupFirstNameLabel.TabIndex = 5;
            this.signupFirstNameLabel.Text = "First name:";
            // 
            // signupFirstnameTextbox
            // 
            this.signupFirstnameTextbox.Location = new System.Drawing.Point(191, 36);
            this.signupFirstnameTextbox.Name = "signupFirstnameTextbox";
            this.signupFirstnameTextbox.Size = new System.Drawing.Size(140, 20);
            this.signupFirstnameTextbox.TabIndex = 6;
            // 
            // signupLastnameLabel
            // 
            this.signupLastnameLabel.AutoSize = true;
            this.signupLastnameLabel.Location = new System.Drawing.Point(191, 68);
            this.signupLastnameLabel.Name = "signupLastnameLabel";
            this.signupLastnameLabel.Size = new System.Drawing.Size(59, 13);
            this.signupLastnameLabel.TabIndex = 7;
            this.signupLastnameLabel.Text = "Last name:";
            // 
            // signupLastnameTextbox
            // 
            this.signupLastnameTextbox.Location = new System.Drawing.Point(191, 84);
            this.signupLastnameTextbox.Name = "signupLastnameTextbox";
            this.signupLastnameTextbox.Size = new System.Drawing.Size(140, 20);
            this.signupLastnameTextbox.TabIndex = 8;
            // 
            // signupRoleCombobox
            // 
            this.signupRoleCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.signupRoleCombobox.FormattingEnabled = true;
            this.signupRoleCombobox.Items.AddRange(new object[] {
            "Professor",
            "Administrator",
            "Support staff member"});
            this.signupRoleCombobox.Location = new System.Drawing.Point(27, 138);
            this.signupRoleCombobox.Name = "signupRoleCombobox";
            this.signupRoleCombobox.Size = new System.Drawing.Size(140, 21);
            this.signupRoleCombobox.TabIndex = 9;
            // 
            // signupRoleLabel
            // 
            this.signupRoleLabel.AutoSize = true;
            this.signupRoleLabel.Location = new System.Drawing.Point(24, 119);
            this.signupRoleLabel.Name = "signupRoleLabel";
            this.signupRoleLabel.Size = new System.Drawing.Size(32, 13);
            this.signupRoleLabel.TabIndex = 10;
            this.signupRoleLabel.Text = "Role:";
            // 
            // Signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 183);
            this.Controls.Add(this.signupRoleLabel);
            this.Controls.Add(this.signupRoleCombobox);
            this.Controls.Add(this.signupLastnameTextbox);
            this.Controls.Add(this.signupLastnameLabel);
            this.Controls.Add(this.signupFirstnameTextbox);
            this.Controls.Add(this.signupFirstNameLabel);
            this.Controls.Add(this.signupSignupButton);
            this.Controls.Add(this.signupPasswordTextbox);
            this.Controls.Add(this.signupPasswordLabel);
            this.Controls.Add(this.signupUsernameTextbox);
            this.Controls.Add(this.signupUsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Signup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up | Studrex - Student Record Database";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Signup_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label signupUsernameLabel;
        private System.Windows.Forms.TextBox signupUsernameTextbox;
        private System.Windows.Forms.Label signupPasswordLabel;
        private System.Windows.Forms.TextBox signupPasswordTextbox;
        private System.Windows.Forms.Button signupSignupButton;
        private System.Windows.Forms.Label signupFirstNameLabel;
        private System.Windows.Forms.TextBox signupFirstnameTextbox;
        private System.Windows.Forms.Label signupLastnameLabel;
        private System.Windows.Forms.TextBox signupLastnameTextbox;
        private System.Windows.Forms.ComboBox signupRoleCombobox;
        private System.Windows.Forms.Label signupRoleLabel;
    }
}