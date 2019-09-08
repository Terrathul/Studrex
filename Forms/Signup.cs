using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studrex.Forms
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Signup_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void SignupSignupButton_Click(object sender, EventArgs e)
        {
            Classes.User user = new Classes.User();
            Database.Database.AddUser(signupUsernameTextbox.Text, signupPasswordTextbox.Text, signupFirstnameTextbox.Text, signupLastnameTextbox.Text, signupRoleCombobox.SelectedIndex);
            user = Database.Database.loadUser(signupUsernameTextbox.Text);
            this.FormClosing -= Signup_FormClosing;
            StudentRecords studentRecordsForm = new StudentRecords(user);
            this.Close();
            studentRecordsForm.Show();
        }
    }
}
