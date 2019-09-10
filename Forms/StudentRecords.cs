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
    public partial class StudentRecords : Form
    {
        Classes.User user;
        public StudentRecords(Classes.User userParam)
        {
            InitializeComponent();
            this.user = userParam;
            if (user.getRole() == 2)
                this.studrexAddButton.Hide();
            studrexWelcomeLabel.Text = "Welcome " + user.getFirstname() + " " + user.getLastName() + "!";  
        }

        private void StudentRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studrexAddButton_Click(object sender, EventArgs e)
        {
            Forms.AddStudent addStudent = new Forms.AddStudent(user);
            this.FormClosing -= StudentRecords_FormClosing;
            this.Close();
            addStudent.Show();
        }
    }
}
