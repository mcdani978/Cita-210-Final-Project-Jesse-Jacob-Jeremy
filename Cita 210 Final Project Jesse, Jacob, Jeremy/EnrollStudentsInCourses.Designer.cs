namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    partial class EnrollStudentsInCourses
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
            EnrollStudentbutton = new Button();
            StudentIDLabel = new Label();
            StudentIDTextbox = new TextBox();
            EnrollInCoursesComboBox = new ComboBox();
            CoursesEnrolledInLabel = new Label();
            CoursesEnrolledIntoListBox = new ListBox();
            EnrollInCourseButton = new Button();
            ClearSelectedCoursesButton = new Button();
            SuspendLayout();
            // 
            // EnrollStudentbutton
            // 
            EnrollStudentbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EnrollStudentbutton.Location = new Point(247, 475);
            EnrollStudentbutton.Name = "EnrollStudentbutton";
            EnrollStudentbutton.Size = new Size(239, 69);
            EnrollStudentbutton.TabIndex = 1;
            EnrollStudentbutton.Text = "Enroll Student";
            EnrollStudentbutton.UseVisualStyleBackColor = true;
            EnrollStudentbutton.Click += EnrollStudentbutton_Click;
            // 
            // StudentIDLabel
            // 
            StudentIDLabel.AutoSize = true;
            StudentIDLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            StudentIDLabel.Location = new Point(2, 16);
            StudentIDLabel.Name = "StudentIDLabel";
            StudentIDLabel.Size = new Size(202, 31);
            StudentIDLabel.TabIndex = 2;
            StudentIDLabel.Text = "Enter Student ID :";
            // 
            // StudentIDTextbox
            // 
            StudentIDTextbox.Location = new Point(210, 20);
            StudentIDTextbox.Name = "StudentIDTextbox";
            StudentIDTextbox.Size = new Size(284, 27);
            StudentIDTextbox.TabIndex = 3;
            StudentIDTextbox.TextChanged += StudentIDTextbox_TextChanged;
            // 
            // EnrollInCoursesComboBox
            // 
            EnrollInCoursesComboBox.FormattingEnabled = true;
            EnrollInCoursesComboBox.Location = new Point(329, 89);
            EnrollInCoursesComboBox.Name = "EnrollInCoursesComboBox";
            EnrollInCoursesComboBox.Size = new Size(284, 28);
            EnrollInCoursesComboBox.TabIndex = 4;
            EnrollInCoursesComboBox.SelectedIndexChanged += EnrollInCoursesComboBox_SelectedIndexChanged;
            // 
            // CoursesEnrolledInLabel
            // 
            CoursesEnrolledInLabel.AutoSize = true;
            CoursesEnrolledInLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            CoursesEnrolledInLabel.Location = new Point(2, 86);
            CoursesEnrolledInLabel.Name = "CoursesEnrolledInLabel";
            CoursesEnrolledInLabel.Size = new Size(321, 31);
            CoursesEnrolledInLabel.TabIndex = 5;
            CoursesEnrolledInLabel.Text = "Enter Courses To Enroll Into :";
            // 
            // CoursesEnrolledIntoListBox
            // 
            CoursesEnrolledIntoListBox.FormattingEnabled = true;
            CoursesEnrolledIntoListBox.ItemHeight = 20;
            CoursesEnrolledIntoListBox.Location = new Point(86, 229);
            CoursesEnrolledIntoListBox.Name = "CoursesEnrolledIntoListBox";
            CoursesEnrolledIntoListBox.Size = new Size(494, 164);
            CoursesEnrolledIntoListBox.TabIndex = 6;
            CoursesEnrolledIntoListBox.SelectedIndexChanged += CoursesEnrolledIntoListBox_SelectedIndexChanged;
            // 
            // EnrollInCourseButton
            // 
            EnrollInCourseButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            EnrollInCourseButton.Location = new Point(56, 138);
            EnrollInCourseButton.Name = "EnrollInCourseButton";
            EnrollInCourseButton.Size = new Size(192, 69);
            EnrollInCourseButton.TabIndex = 7;
            EnrollInCourseButton.Text = "Add To Cart";
            EnrollInCourseButton.UseVisualStyleBackColor = true;
            EnrollInCourseButton.Click += EnrollInCourseButton_Click;
            // 
            // ClearSelectedCoursesButton
            // 
            ClearSelectedCoursesButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ClearSelectedCoursesButton.Location = new Point(458, 138);
            ClearSelectedCoursesButton.Name = "ClearSelectedCoursesButton";
            ClearSelectedCoursesButton.Size = new Size(192, 69);
            ClearSelectedCoursesButton.TabIndex = 8;
            ClearSelectedCoursesButton.Text = " Clear Selected Courses";
            ClearSelectedCoursesButton.UseVisualStyleBackColor = true;
            ClearSelectedCoursesButton.Click += ClearSelectedCoursesButton_Click;
            // 
            // EnrollStudentsInCourses
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 556);
            Controls.Add(ClearSelectedCoursesButton);
            Controls.Add(EnrollInCourseButton);
            Controls.Add(CoursesEnrolledIntoListBox);
            Controls.Add(CoursesEnrolledInLabel);
            Controls.Add(EnrollInCoursesComboBox);
            Controls.Add(StudentIDTextbox);
            Controls.Add(StudentIDLabel);
            Controls.Add(EnrollStudentbutton);
            Name = "EnrollStudentsInCourses";
            Text = "EnrollStudentsInCourses";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button EnrollStudentbutton;
        private Label StudentIDLabel;
        private TextBox StudentIDTextbox;
        private ComboBox EnrollInCoursesComboBox;
        private Label CoursesEnrolledInLabel;
        private ListBox CoursesEnrolledIntoListBox;
        private Button EnrollInCourseButton;
        private Button ClearSelectedCoursesButton;
    }
}