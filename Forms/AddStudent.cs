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
    public partial class AddStudent : Form
    {
        Classes.User user;
        public AddStudent(Classes.User userParam)
        {
            this.user = userParam;
            InitializeComponent();
        }

        private void AddStudent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void studentAddButton_Click(object sender, EventArgs e)
        {
            byte[] bytefield = Database.Database.ImageToByte(studentPhotobox.Image, System.Drawing.Imaging.ImageFormat.Jpeg);
            if(!string.IsNullOrWhiteSpace(studentFirstNameTextbox.Text) && !string.IsNullOrWhiteSpace(studentLastNameTextbox.Text) && studentProgramCombobox.SelectedIndex > -1 && studentLevelCombobox.SelectedIndex > -1 && studentYearCombobox.SelectedIndex > -1)
            {
                Database.Database.AddStudent(studentFirstNameTextbox.Text, studentLastNameTextbox.Text, studentProgramCombobox.Text, studentLevelCombobox.Text, studentYearCombobox.SelectedIndex + 1, bytefield);
                var selectedOption = MessageBox.Show("Do you want to add another student?", "Add another?", MessageBoxButtons.YesNo);
                if(selectedOption == DialogResult.Yes)
                {
                    
                }
                else
                {
                    StudentRecords records = new StudentRecords(user);
                    records.Show();
                    this.FormClosing -= AddStudent_FormClosing;
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Make sure to fill all fields.");
            }
        }

        private void loadPhotoButton_Click(object sender, EventArgs e)
        {
            loadImageFile.Filter = "Image Files(*.jpeg;*.bmp;*.png;*.jpg)|*.jpeg;*.bmp;*.png;*.jpg";
            if (loadImageFile.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                photoPathTextbox.Text = loadImageFile.FileName;
                this.studentPhotobox.Image = Image.FromFile(loadImageFile.FileName);
            }
        }


    }
}
