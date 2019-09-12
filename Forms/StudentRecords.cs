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
            Database.Database.LoadStudents(studentDataGridView);
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

        private void studrexSearchButton_Click(object sender, EventArgs e)
        {
            if(idsearchTextbox.Text.Length == 7)
            {
                Database.Database.SearchDatabase(idsearchTextbox.Text, studentDataGridView);
                idsearchTextbox.Text = "";
                if (studentDataGridView.Rows.Count == 0)
                    MessageBox.Show("There are no students with that student ID.");
            }
            else
            {
                MessageBox.Show("Incorrect format of student ID number."); 
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            studentDataGridView.Rows.Clear();
            studentDataGridView.Refresh();
            Database.Database.LoadStudents(studentDataGridView);
        }

        private void studrexProgramCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.Database.FilterDatabaseByProgram(studrexProgramCombobox.SelectedIndex, studentDataGridView);
            if (studentDataGridView.Rows.Count == 0)
                MessageBox.Show("There are currently no students studying " + studrexProgramCombobox.Text + " at Pelotopia School of Business.");
            
        }

        private void studrexLevelCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.Database.FilterDatabaseByLevel(studrexLevelCombobox.SelectedIndex, studentDataGridView);
            if (studentDataGridView.Rows.Count == 0)
                MessageBox.Show("There are currently no " + studrexLevelCombobox.Text.ToLower() + "-level students at Pelotopia School of Business.");
        }

        private void studrexYearCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Database.Database.FilterDatabaseByYear(studrexYearCombobox.SelectedIndex+1, studentDataGridView);
            if (studentDataGridView.Rows.Count == 0)
            {
                int year = studrexYearCombobox.SelectedIndex + 1;
                if (year == 1)
                    MessageBox.Show("There are currently no " + year + "st-year students at Pelotopia School of Business.");
                if (year == 2)
                    MessageBox.Show("There are currently no " + year + "nd-year students at Pelotopia School of Business.");
                if (year == 3)
                    MessageBox.Show("There are currently no " + year + "rd-year students at Pelotopia School of Business.");
            }
                
        }
    }
}
