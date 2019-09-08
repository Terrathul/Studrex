using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studrex
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            if (!Database.Database.DatabaseExists())
                Database.Database.createDatabase();
        }

        private void LoginSignupLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.Signup signup = new Forms.Signup();
            signup.Show();
            this.FormClosing -= Login_FormClosing;
            this.Close();
        }

        private void LoginLoginButton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(loginUsernameTextbox.Text) && !string.IsNullOrEmpty(loginPasswordTextbox.Text))
            {
                if (Database.Database.UsernameExists(loginUsernameTextbox.Text))
                {
                    if (Database.Database.PasswordExists(loginUsernameTextbox.Text, loginPasswordTextbox.Text))
                    {
                        Classes.User user = new Classes.User();
                        user = Database.Database.loadUser(loginUsernameTextbox.Text);
                        this.FormClosing -= Login_FormClosing;
                        this.Close();
                        Forms.StudentRecords studentRecords = new Forms.StudentRecords(user);
                        studentRecords.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username and password do not match. Please try again.");
                    }
                }
                else
                {
                    MessageBox.Show("Username does not exist. Make sure to enter correct username or sign up to use the service.");
                }
            }
            else
            {
                MessageBox.Show("Make sure to fill out all the fields.");
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
