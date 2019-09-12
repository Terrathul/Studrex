namespace Studrex.Forms
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.studentPhotoLabel = new System.Windows.Forms.Label();
            this.studentPhotobox = new System.Windows.Forms.PictureBox();
            this.photoPathTextbox = new System.Windows.Forms.TextBox();
            this.loadPhotoButton = new System.Windows.Forms.Button();
            this.studentFirstNameLabel = new System.Windows.Forms.Label();
            this.studentFirstNameTextbox = new System.Windows.Forms.TextBox();
            this.studentLastnameLabel = new System.Windows.Forms.Label();
            this.studentLastNameTextbox = new System.Windows.Forms.TextBox();
            this.studentProgramLabel = new System.Windows.Forms.Label();
            this.studentProgramCombobox = new System.Windows.Forms.ComboBox();
            this.studentLevelLabel = new System.Windows.Forms.Label();
            this.studentLevelCombobox = new System.Windows.Forms.ComboBox();
            this.studentYearLabel = new System.Windows.Forms.Label();
            this.studentYearCombobox = new System.Windows.Forms.ComboBox();
            this.studentAddButton = new System.Windows.Forms.Button();
            this.loadImageFile = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.studentPhotobox)).BeginInit();
            this.SuspendLayout();
            // 
            // studentPhotoLabel
            // 
            this.studentPhotoLabel.AutoSize = true;
            this.studentPhotoLabel.Location = new System.Drawing.Point(13, 13);
            this.studentPhotoLabel.Name = "studentPhotoLabel";
            this.studentPhotoLabel.Size = new System.Drawing.Size(38, 13);
            this.studentPhotoLabel.TabIndex = 0;
            this.studentPhotoLabel.Text = "Photo:";
            // 
            // studentPhotobox
            // 
            this.studentPhotobox.Image = ((System.Drawing.Image)(resources.GetObject("studentPhotobox.Image")));
            this.studentPhotobox.Location = new System.Drawing.Point(16, 29);
            this.studentPhotobox.Name = "studentPhotobox";
            this.studentPhotobox.Size = new System.Drawing.Size(205, 206);
            this.studentPhotobox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.studentPhotobox.TabIndex = 1;
            this.studentPhotobox.TabStop = false;
            // 
            // photoPathTextbox
            // 
            this.photoPathTextbox.Location = new System.Drawing.Point(16, 244);
            this.photoPathTextbox.Name = "photoPathTextbox";
            this.photoPathTextbox.Size = new System.Drawing.Size(126, 20);
            this.photoPathTextbox.TabIndex = 2;
            // 
            // loadPhotoButton
            // 
            this.loadPhotoButton.Location = new System.Drawing.Point(146, 244);
            this.loadPhotoButton.Name = "loadPhotoButton";
            this.loadPhotoButton.Size = new System.Drawing.Size(75, 21);
            this.loadPhotoButton.TabIndex = 3;
            this.loadPhotoButton.Text = "Load photo";
            this.loadPhotoButton.UseVisualStyleBackColor = true;
            this.loadPhotoButton.Click += new System.EventHandler(this.loadPhotoButton_Click);
            // 
            // studentFirstNameLabel
            // 
            this.studentFirstNameLabel.AutoSize = true;
            this.studentFirstNameLabel.Location = new System.Drawing.Point(240, 13);
            this.studentFirstNameLabel.Name = "studentFirstNameLabel";
            this.studentFirstNameLabel.Size = new System.Drawing.Size(58, 13);
            this.studentFirstNameLabel.TabIndex = 4;
            this.studentFirstNameLabel.Text = "First name:";
            // 
            // studentFirstNameTextbox
            // 
            this.studentFirstNameTextbox.Location = new System.Drawing.Point(243, 30);
            this.studentFirstNameTextbox.Name = "studentFirstNameTextbox";
            this.studentFirstNameTextbox.Size = new System.Drawing.Size(124, 20);
            this.studentFirstNameTextbox.TabIndex = 5;
            // 
            // studentLastnameLabel
            // 
            this.studentLastnameLabel.AutoSize = true;
            this.studentLastnameLabel.Location = new System.Drawing.Point(240, 58);
            this.studentLastnameLabel.Name = "studentLastnameLabel";
            this.studentLastnameLabel.Size = new System.Drawing.Size(59, 13);
            this.studentLastnameLabel.TabIndex = 6;
            this.studentLastnameLabel.Text = "Last name:";
            // 
            // studentLastNameTextbox
            // 
            this.studentLastNameTextbox.Location = new System.Drawing.Point(243, 74);
            this.studentLastNameTextbox.Name = "studentLastNameTextbox";
            this.studentLastNameTextbox.Size = new System.Drawing.Size(124, 20);
            this.studentLastNameTextbox.TabIndex = 7;
            // 
            // studentProgramLabel
            // 
            this.studentProgramLabel.AutoSize = true;
            this.studentProgramLabel.Location = new System.Drawing.Point(240, 102);
            this.studentProgramLabel.Name = "studentProgramLabel";
            this.studentProgramLabel.Size = new System.Drawing.Size(49, 13);
            this.studentProgramLabel.TabIndex = 8;
            this.studentProgramLabel.Text = "Program:";
            // 
            // studentProgramCombobox
            // 
            this.studentProgramCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentProgramCombobox.FormattingEnabled = true;
            this.studentProgramCombobox.Items.AddRange(new object[] {
            "Administration",
            "Business",
            "Design",
            "Economics",
            "Finance",
            "Informatics",
            "Leadership",
            "Management",
            "Marketing"});
            this.studentProgramCombobox.Location = new System.Drawing.Point(243, 118);
            this.studentProgramCombobox.Name = "studentProgramCombobox";
            this.studentProgramCombobox.Size = new System.Drawing.Size(124, 21);
            this.studentProgramCombobox.TabIndex = 9;
            // 
            // studentLevelLabel
            // 
            this.studentLevelLabel.AutoSize = true;
            this.studentLevelLabel.Location = new System.Drawing.Point(240, 151);
            this.studentLevelLabel.Name = "studentLevelLabel";
            this.studentLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.studentLevelLabel.TabIndex = 10;
            this.studentLevelLabel.Text = "Level:";
            // 
            // studentLevelCombobox
            // 
            this.studentLevelCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentLevelCombobox.FormattingEnabled = true;
            this.studentLevelCombobox.Items.AddRange(new object[] {
            "Undergraduate",
            "Graduate"});
            this.studentLevelCombobox.Location = new System.Drawing.Point(243, 168);
            this.studentLevelCombobox.Name = "studentLevelCombobox";
            this.studentLevelCombobox.Size = new System.Drawing.Size(124, 21);
            this.studentLevelCombobox.TabIndex = 11;
            // 
            // studentYearLabel
            // 
            this.studentYearLabel.AutoSize = true;
            this.studentYearLabel.Location = new System.Drawing.Point(240, 201);
            this.studentYearLabel.Name = "studentYearLabel";
            this.studentYearLabel.Size = new System.Drawing.Size(32, 13);
            this.studentYearLabel.TabIndex = 12;
            this.studentYearLabel.Text = "Year:";
            // 
            // studentYearCombobox
            // 
            this.studentYearCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studentYearCombobox.FormattingEnabled = true;
            this.studentYearCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.studentYearCombobox.Location = new System.Drawing.Point(243, 217);
            this.studentYearCombobox.Name = "studentYearCombobox";
            this.studentYearCombobox.Size = new System.Drawing.Size(124, 21);
            this.studentYearCombobox.TabIndex = 13;
            // 
            // studentAddButton
            // 
            this.studentAddButton.Location = new System.Drawing.Point(243, 244);
            this.studentAddButton.Name = "studentAddButton";
            this.studentAddButton.Size = new System.Drawing.Size(124, 21);
            this.studentAddButton.TabIndex = 14;
            this.studentAddButton.Text = "Add";
            this.studentAddButton.UseVisualStyleBackColor = true;
            this.studentAddButton.Click += new System.EventHandler(this.studentAddButton_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 278);
            this.Controls.Add(this.studentAddButton);
            this.Controls.Add(this.studentYearCombobox);
            this.Controls.Add(this.studentYearLabel);
            this.Controls.Add(this.studentLevelCombobox);
            this.Controls.Add(this.studentLevelLabel);
            this.Controls.Add(this.studentProgramCombobox);
            this.Controls.Add(this.studentProgramLabel);
            this.Controls.Add(this.studentLastNameTextbox);
            this.Controls.Add(this.studentLastnameLabel);
            this.Controls.Add(this.studentFirstNameTextbox);
            this.Controls.Add(this.studentFirstNameLabel);
            this.Controls.Add(this.loadPhotoButton);
            this.Controls.Add(this.photoPathTextbox);
            this.Controls.Add(this.studentPhotobox);
            this.Controls.Add(this.studentPhotoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add student | Studrex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddStudent_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.studentPhotobox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label studentPhotoLabel;
        private System.Windows.Forms.PictureBox studentPhotobox;
        private System.Windows.Forms.TextBox photoPathTextbox;
        private System.Windows.Forms.Button loadPhotoButton;
        private System.Windows.Forms.Label studentFirstNameLabel;
        private System.Windows.Forms.TextBox studentFirstNameTextbox;
        private System.Windows.Forms.Label studentLastnameLabel;
        private System.Windows.Forms.TextBox studentLastNameTextbox;
        private System.Windows.Forms.Label studentProgramLabel;
        private System.Windows.Forms.ComboBox studentProgramCombobox;
        private System.Windows.Forms.Label studentLevelLabel;
        private System.Windows.Forms.ComboBox studentLevelCombobox;
        private System.Windows.Forms.Label studentYearLabel;
        private System.Windows.Forms.ComboBox studentYearCombobox;
        private System.Windows.Forms.Button studentAddButton;
        private System.Windows.Forms.OpenFileDialog loadImageFile;
    }
}