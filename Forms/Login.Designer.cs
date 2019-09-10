namespace Studrex
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.loginUsernameLabel = new System.Windows.Forms.Label();
            this.loginPasswordLabel = new System.Windows.Forms.Label();
            this.loginUsernameTextbox = new System.Windows.Forms.TextBox();
            this.loginPasswordTextbox = new System.Windows.Forms.TextBox();
            this.loginLoginButton = new System.Windows.Forms.Button();
            this.loginPictureBox = new System.Windows.Forms.PictureBox();
            this.loginQueryLabel = new System.Windows.Forms.Label();
            this.loginSignupLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loginUsernameLabel
            // 
            this.loginUsernameLabel.AutoSize = true;
            this.loginUsernameLabel.Location = new System.Drawing.Point(202, 55);
            this.loginUsernameLabel.Name = "loginUsernameLabel";
            this.loginUsernameLabel.Size = new System.Drawing.Size(58, 13);
            this.loginUsernameLabel.TabIndex = 0;
            this.loginUsernameLabel.Text = "Username:";
            // 
            // loginPasswordLabel
            // 
            this.loginPasswordLabel.AutoSize = true;
            this.loginPasswordLabel.Location = new System.Drawing.Point(202, 104);
            this.loginPasswordLabel.Name = "loginPasswordLabel";
            this.loginPasswordLabel.Size = new System.Drawing.Size(56, 13);
            this.loginPasswordLabel.TabIndex = 1;
            this.loginPasswordLabel.Text = "Password:";
            // 
            // loginUsernameTextbox
            // 
            this.loginUsernameTextbox.Location = new System.Drawing.Point(205, 71);
            this.loginUsernameTextbox.Name = "loginUsernameTextbox";
            this.loginUsernameTextbox.Size = new System.Drawing.Size(140, 20);
            this.loginUsernameTextbox.TabIndex = 2;
            // 
            // loginPasswordTextbox
            // 
            this.loginPasswordTextbox.Location = new System.Drawing.Point(205, 120);
            this.loginPasswordTextbox.Name = "loginPasswordTextbox";
            this.loginPasswordTextbox.Size = new System.Drawing.Size(140, 20);
            this.loginPasswordTextbox.TabIndex = 3;
            this.loginPasswordTextbox.UseSystemPasswordChar = true;
            // 
            // loginLoginButton
            // 
            this.loginLoginButton.Location = new System.Drawing.Point(270, 146);
            this.loginLoginButton.Name = "loginLoginButton";
            this.loginLoginButton.Size = new System.Drawing.Size(75, 23);
            this.loginLoginButton.TabIndex = 4;
            this.loginLoginButton.Text = "Log in";
            this.loginLoginButton.UseVisualStyleBackColor = true;
            this.loginLoginButton.Click += new System.EventHandler(this.LoginLoginButton_Click);
            // 
            // loginPictureBox
            // 
            this.loginPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("loginPictureBox.Image")));
            this.loginPictureBox.Location = new System.Drawing.Point(38, 38);
            this.loginPictureBox.Name = "loginPictureBox";
            this.loginPictureBox.Size = new System.Drawing.Size(140, 140);
            this.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.loginPictureBox.TabIndex = 5;
            this.loginPictureBox.TabStop = false;
            // 
            // loginQueryLabel
            // 
            this.loginQueryLabel.AutoSize = true;
            this.loginQueryLabel.Location = new System.Drawing.Point(86, 192);
            this.loginQueryLabel.Name = "loginQueryLabel";
            this.loginQueryLabel.Size = new System.Drawing.Size(122, 13);
            this.loginQueryLabel.TabIndex = 6;
            this.loginQueryLabel.Text = "Don\'t have an account?";
            // 
            // loginSignupLinkLabel
            // 
            this.loginSignupLinkLabel.AutoSize = true;
            this.loginSignupLinkLabel.Location = new System.Drawing.Point(214, 192);
            this.loginSignupLinkLabel.Name = "loginSignupLinkLabel";
            this.loginSignupLinkLabel.Size = new System.Drawing.Size(46, 13);
            this.loginSignupLinkLabel.TabIndex = 7;
            this.loginSignupLinkLabel.TabStop = true;
            this.loginSignupLinkLabel.Text = "Sign up!";
            this.loginSignupLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LoginSignupLinkLabel_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 235);
            this.Controls.Add(this.loginSignupLinkLabel);
            this.Controls.Add(this.loginQueryLabel);
            this.Controls.Add(this.loginPictureBox);
            this.Controls.Add(this.loginLoginButton);
            this.Controls.Add(this.loginPasswordTextbox);
            this.Controls.Add(this.loginUsernameTextbox);
            this.Controls.Add(this.loginPasswordLabel);
            this.Controls.Add(this.loginUsernameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login | Studrex ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.loginPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginUsernameLabel;
        private System.Windows.Forms.Label loginPasswordLabel;
        private System.Windows.Forms.TextBox loginUsernameTextbox;
        private System.Windows.Forms.TextBox loginPasswordTextbox;
        private System.Windows.Forms.Button loginLoginButton;
        private System.Windows.Forms.PictureBox loginPictureBox;
        private System.Windows.Forms.Label loginQueryLabel;
        private System.Windows.Forms.LinkLabel loginSignupLinkLabel;
    }
}

