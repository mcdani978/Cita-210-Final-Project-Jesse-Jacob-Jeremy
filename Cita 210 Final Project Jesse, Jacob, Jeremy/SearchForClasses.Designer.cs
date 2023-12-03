namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    partial class SearchForClasses
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
            CourseIdLabel = new Label();
            CourseIdTextBox = new TextBox();
            AndOrLabel = new Label();
            CourseNameLabel = new Label();
            CourseNameTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            SearchForCourseButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // CourseIdLabel
            // 
            CourseIdLabel.AutoSize = true;
            CourseIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CourseIdLabel.Location = new Point(12, 28);
            CourseIdLabel.Name = "CourseIdLabel";
            CourseIdLabel.Size = new Size(265, 38);
            CourseIdLabel.TabIndex = 0;
            CourseIdLabel.Text = "Enter A Course ID :";
            // 
            // CourseIdTextBox
            // 
            CourseIdTextBox.Location = new Point(283, 39);
            CourseIdTextBox.Name = "CourseIdTextBox";
            CourseIdTextBox.Size = new Size(312, 27);
            CourseIdTextBox.TabIndex = 1;
            // 
            // AndOrLabel
            // 
            AndOrLabel.AutoSize = true;
            AndOrLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AndOrLabel.Location = new Point(283, 126);
            AndOrLabel.Name = "AndOrLabel";
            AndOrLabel.Size = new Size(111, 38);
            AndOrLabel.TabIndex = 2;
            AndOrLabel.Text = "And Or";
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CourseNameLabel.Location = new Point(12, 192);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(313, 38);
            CourseNameLabel.TabIndex = 3;
            CourseNameLabel.Text = "Enter A Course Name :";
            // 
            // CourseNameTextbox
            // 
            CourseNameTextbox.Location = new Point(331, 203);
            CourseNameTextbox.Name = "CourseNameTextbox";
            CourseNameTextbox.Size = new Size(300, 27);
            CourseNameTextbox.TabIndex = 4;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(61, 246);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(580, 94);
            dataGridView1.TabIndex = 5;
            // 
            // SearchForCourseButton
            // 
            SearchForCourseButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SearchForCourseButton.Location = new Point(156, 376);
            SearchForCourseButton.Name = "SearchForCourseButton";
            SearchForCourseButton.Size = new Size(378, 65);
            SearchForCourseButton.TabIndex = 6;
            SearchForCourseButton.Text = "Search For A Course";
            SearchForCourseButton.UseVisualStyleBackColor = true;
            SearchForCourseButton.Click += SearchForCourseButton_Click;
            // 
            // SearchForClasses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(727, 484);
            Controls.Add(SearchForCourseButton);
            Controls.Add(dataGridView1);
            Controls.Add(CourseNameTextbox);
            Controls.Add(CourseNameLabel);
            Controls.Add(AndOrLabel);
            Controls.Add(CourseIdTextBox);
            Controls.Add(CourseIdLabel);
            Name = "SearchForClasses";
            Text = "Search For Classes";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CourseIdLabel;
        private TextBox CourseIdTextBox;
        private Label AndOrLabel;
        private Label CourseNameLabel;
        private TextBox CourseNameTextbox;
        private DataGridView dataGridView1;
        private Button SearchForCourseButton;
    }
}