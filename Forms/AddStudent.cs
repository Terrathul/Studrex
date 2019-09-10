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

        }

        private void loadPhotoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
