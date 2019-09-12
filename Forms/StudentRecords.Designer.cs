namespace Studrex.Forms
{
    partial class StudentRecords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StudentRecords));
            this.studrexAddButton = new System.Windows.Forms.Button();
            this.studentDataGridView = new System.Windows.Forms.DataGridView();
            this.photoColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentProgram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studrexSearchGroupbox = new System.Windows.Forms.GroupBox();
            this.studrexIdLabel = new System.Windows.Forms.Label();
            this.idsearchTextbox = new System.Windows.Forms.TextBox();
            this.studrexSearchButton = new System.Windows.Forms.Button();
            this.studrexFilterGroupbox = new System.Windows.Forms.GroupBox();
            this.studrexYearCombobox = new System.Windows.Forms.ComboBox();
            this.studrexYearLabel = new System.Windows.Forms.Label();
            this.studrexLevelCombobox = new System.Windows.Forms.ComboBox();
            this.studrexLevelLabel = new System.Windows.Forms.Label();
            this.studrexProgramCombobox = new System.Windows.Forms.ComboBox();
            this.studrexProgramLabel = new System.Windows.Forms.Label();
            this.studrexWelcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).BeginInit();
            this.studrexSearchGroupbox.SuspendLayout();
            this.studrexFilterGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // studrexAddButton
            // 
            this.studrexAddButton.Location = new System.Drawing.Point(713, 415);
            this.studrexAddButton.Name = "studrexAddButton";
            this.studrexAddButton.Size = new System.Drawing.Size(75, 23);
            this.studrexAddButton.TabIndex = 1;
            this.studrexAddButton.Text = "Add student";
            this.studrexAddButton.UseVisualStyleBackColor = true;
            this.studrexAddButton.Click += new System.EventHandler(this.studrexAddButton_Click);
            // 
            // studentDataGridView
            // 
            this.studentDataGridView.AllowUserToAddRows = false;
            this.studentDataGridView.AllowUserToDeleteRows = false;
            this.studentDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.studentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studentDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.photoColumn,
            this.studentName,
            this.studentLastname,
            this.studentProgram,
            this.studentLevel,
            this.studentYear});
            this.studentDataGridView.Location = new System.Drawing.Point(12, 80);
            this.studentDataGridView.MultiSelect = false;
            this.studentDataGridView.Name = "studentDataGridView";
            this.studentDataGridView.ReadOnly = true;
            this.studentDataGridView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.studentDataGridView.RowHeadersVisible = false;
            this.studentDataGridView.RowTemplate.Height = 129;
            this.studentDataGridView.Size = new System.Drawing.Size(776, 329);
            this.studentDataGridView.TabIndex = 2;
            // 
            // photoColumn
            // 
            this.photoColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.photoColumn.HeaderText = "Photo";
            this.photoColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.photoColumn.Name = "photoColumn";
            this.photoColumn.ReadOnly = true;
            this.photoColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.photoColumn.Width = 129;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "First name";
            this.studentName.Name = "studentName";
            this.studentName.ReadOnly = true;
            // 
            // studentLastname
            // 
            this.studentLastname.HeaderText = "Last name";
            this.studentLastname.Name = "studentLastname";
            this.studentLastname.ReadOnly = true;
            // 
            // studentProgram
            // 
            this.studentProgram.HeaderText = "Program";
            this.studentProgram.Name = "studentProgram";
            this.studentProgram.ReadOnly = true;
            // 
            // studentLevel
            // 
            this.studentLevel.HeaderText = "Level";
            this.studentLevel.Name = "studentLevel";
            this.studentLevel.ReadOnly = true;
            // 
            // studentYear
            // 
            this.studentYear.HeaderText = "Year";
            this.studentYear.Name = "studentYear";
            this.studentYear.ReadOnly = true;
            // 
            // studrexSearchGroupbox
            // 
            this.studrexSearchGroupbox.Controls.Add(this.studrexIdLabel);
            this.studrexSearchGroupbox.Controls.Add(this.idsearchTextbox);
            this.studrexSearchGroupbox.Controls.Add(this.studrexSearchButton);
            this.studrexSearchGroupbox.Location = new System.Drawing.Point(12, 27);
            this.studrexSearchGroupbox.Name = "studrexSearchGroupbox";
            this.studrexSearchGroupbox.Size = new System.Drawing.Size(255, 47);
            this.studrexSearchGroupbox.TabIndex = 3;
            this.studrexSearchGroupbox.TabStop = false;
            this.studrexSearchGroupbox.Text = "Search";
            // 
            // studrexIdLabel
            // 
            this.studrexIdLabel.AutoSize = true;
            this.studrexIdLabel.Location = new System.Drawing.Point(6, 22);
            this.studrexIdLabel.Name = "studrexIdLabel";
            this.studrexIdLabel.Size = new System.Drawing.Size(59, 13);
            this.studrexIdLabel.TabIndex = 6;
            this.studrexIdLabel.Text = "ID number:";
            // 
            // idsearchTextbox
            // 
            this.idsearchTextbox.Location = new System.Drawing.Point(68, 19);
            this.idsearchTextbox.Name = "idsearchTextbox";
            this.idsearchTextbox.Size = new System.Drawing.Size(100, 20);
            this.idsearchTextbox.TabIndex = 5;
            // 
            // studrexSearchButton
            // 
            this.studrexSearchButton.Location = new System.Drawing.Point(174, 18);
            this.studrexSearchButton.Name = "studrexSearchButton";
            this.studrexSearchButton.Size = new System.Drawing.Size(75, 20);
            this.studrexSearchButton.TabIndex = 4;
            this.studrexSearchButton.Text = "Search";
            this.studrexSearchButton.UseVisualStyleBackColor = true;
            this.studrexSearchButton.Click += new System.EventHandler(this.studrexSearchButton_Click);
            // 
            // studrexFilterGroupbox
            // 
            this.studrexFilterGroupbox.Controls.Add(this.studrexYearCombobox);
            this.studrexFilterGroupbox.Controls.Add(this.studrexYearLabel);
            this.studrexFilterGroupbox.Controls.Add(this.studrexLevelCombobox);
            this.studrexFilterGroupbox.Controls.Add(this.studrexLevelLabel);
            this.studrexFilterGroupbox.Controls.Add(this.studrexProgramCombobox);
            this.studrexFilterGroupbox.Controls.Add(this.studrexProgramLabel);
            this.studrexFilterGroupbox.Location = new System.Drawing.Point(273, 27);
            this.studrexFilterGroupbox.Name = "studrexFilterGroupbox";
            this.studrexFilterGroupbox.Size = new System.Drawing.Size(515, 47);
            this.studrexFilterGroupbox.TabIndex = 4;
            this.studrexFilterGroupbox.TabStop = false;
            this.studrexFilterGroupbox.Text = "Filter";
            // 
            // studrexYearCombobox
            // 
            this.studrexYearCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studrexYearCombobox.FormattingEnabled = true;
            this.studrexYearCombobox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.studrexYearCombobox.Location = new System.Drawing.Point(450, 14);
            this.studrexYearCombobox.Name = "studrexYearCombobox";
            this.studrexYearCombobox.Size = new System.Drawing.Size(40, 21);
            this.studrexYearCombobox.TabIndex = 5;
            this.studrexYearCombobox.SelectedIndexChanged += new System.EventHandler(this.studrexYearCombobox_SelectedIndexChanged);
            // 
            // studrexYearLabel
            // 
            this.studrexYearLabel.AutoSize = true;
            this.studrexYearLabel.Location = new System.Drawing.Point(412, 17);
            this.studrexYearLabel.Name = "studrexYearLabel";
            this.studrexYearLabel.Size = new System.Drawing.Size(32, 13);
            this.studrexYearLabel.TabIndex = 4;
            this.studrexYearLabel.Text = "Year:";
            // 
            // studrexLevelCombobox
            // 
            this.studrexLevelCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studrexLevelCombobox.FormattingEnabled = true;
            this.studrexLevelCombobox.Items.AddRange(new object[] {
            "Undergraduate",
            "Graduate"});
            this.studrexLevelCombobox.Location = new System.Drawing.Point(259, 15);
            this.studrexLevelCombobox.Name = "studrexLevelCombobox";
            this.studrexLevelCombobox.Size = new System.Drawing.Size(121, 21);
            this.studrexLevelCombobox.TabIndex = 3;
            this.studrexLevelCombobox.SelectedIndexChanged += new System.EventHandler(this.studrexLevelCombobox_SelectedIndexChanged);
            // 
            // studrexLevelLabel
            // 
            this.studrexLevelLabel.AutoSize = true;
            this.studrexLevelLabel.Location = new System.Drawing.Point(217, 19);
            this.studrexLevelLabel.Name = "studrexLevelLabel";
            this.studrexLevelLabel.Size = new System.Drawing.Size(36, 13);
            this.studrexLevelLabel.TabIndex = 2;
            this.studrexLevelLabel.Text = "Level:";
            // 
            // studrexProgramCombobox
            // 
            this.studrexProgramCombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.studrexProgramCombobox.FormattingEnabled = true;
            this.studrexProgramCombobox.Items.AddRange(new object[] {
            "Administration",
            "Business",
            "Design",
            "Economics",
            "Finance",
            "Informatics",
            "Leadership",
            "Management",
            "Marketing"});
            this.studrexProgramCombobox.Location = new System.Drawing.Point(73, 16);
            this.studrexProgramCombobox.Name = "studrexProgramCombobox";
            this.studrexProgramCombobox.Size = new System.Drawing.Size(121, 21);
            this.studrexProgramCombobox.TabIndex = 1;
            this.studrexProgramCombobox.SelectedIndexChanged += new System.EventHandler(this.studrexProgramCombobox_SelectedIndexChanged);
            // 
            // studrexProgramLabel
            // 
            this.studrexProgramLabel.AutoSize = true;
            this.studrexProgramLabel.Location = new System.Drawing.Point(20, 21);
            this.studrexProgramLabel.Name = "studrexProgramLabel";
            this.studrexProgramLabel.Size = new System.Drawing.Size(49, 13);
            this.studrexProgramLabel.TabIndex = 0;
            this.studrexProgramLabel.Text = "Program:";
            // 
            // studrexWelcomeLabel
            // 
            this.studrexWelcomeLabel.AutoSize = true;
            this.studrexWelcomeLabel.Location = new System.Drawing.Point(13, 8);
            this.studrexWelcomeLabel.Name = "studrexWelcomeLabel";
            this.studrexWelcomeLabel.Size = new System.Drawing.Size(35, 13);
            this.studrexWelcomeLabel.TabIndex = 5;
            this.studrexWelcomeLabel.Text = "label1";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(501, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Studrex | Student database of Pelotopia School of Business";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(12, 415);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 7;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // StudentRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.studrexWelcomeLabel);
            this.Controls.Add(this.studrexFilterGroupbox);
            this.Controls.Add(this.studrexSearchGroupbox);
            this.Controls.Add(this.studentDataGridView);
            this.Controls.Add(this.studrexAddButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StudentRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Records | Studrex";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentRecords_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.studentDataGridView)).EndInit();
            this.studrexSearchGroupbox.ResumeLayout(false);
            this.studrexSearchGroupbox.PerformLayout();
            this.studrexFilterGroupbox.ResumeLayout(false);
            this.studrexFilterGroupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button studrexAddButton;
        private System.Windows.Forms.DataGridView studentDataGridView;
        private System.Windows.Forms.GroupBox studrexSearchGroupbox;
        private System.Windows.Forms.Label studrexIdLabel;
        private System.Windows.Forms.TextBox idsearchTextbox;
        private System.Windows.Forms.Button studrexSearchButton;
        private System.Windows.Forms.GroupBox studrexFilterGroupbox;
        private System.Windows.Forms.ComboBox studrexYearCombobox;
        private System.Windows.Forms.Label studrexYearLabel;
        private System.Windows.Forms.ComboBox studrexLevelCombobox;
        private System.Windows.Forms.Label studrexLevelLabel;
        private System.Windows.Forms.ComboBox studrexProgramCombobox;
        private System.Windows.Forms.Label studrexProgramLabel;
        private System.Windows.Forms.Label studrexWelcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn photoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentYear;
        private System.Windows.Forms.Button refreshButton;
    }
}