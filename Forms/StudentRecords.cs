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
        public StudentRecords(Classes.User user)
        {
            InitializeComponent();
            helloLabel.Text = user.getUsername();
        }

        private void StudentRecords_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
