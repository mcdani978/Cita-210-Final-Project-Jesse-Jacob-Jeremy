namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
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
            StudentIdlabel = new Label();
            StudentIdTextbox = new TextBox();
            Studentnamelabel = new Label();
            StudentNameTextbox = new TextBox();
            AddStudentButton = new Button();
            SuspendLayout();
            // 
            // StudentIdlabel
            // 
            StudentIdlabel.AutoSize = true;
            StudentIdlabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            StudentIdlabel.Location = new Point(60, 58);
            StudentIdlabel.Name = "StudentIdlabel";
            StudentIdlabel.Size = new Size(279, 38);
            StudentIdlabel.TabIndex = 0;
            StudentIdlabel.Text = "Enter A Student ID :";
            // 
            // StudentIdTextbox
            // 
            StudentIdTextbox.Location = new Point(355, 69);
            StudentIdTextbox.Name = "StudentIdTextbox";
            StudentIdTextbox.Size = new Size(272, 27);
            StudentIdTextbox.TabIndex = 1;
            // 
            // Studentnamelabel
            // 
            Studentnamelabel.AutoSize = true;
            Studentnamelabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            Studentnamelabel.Location = new Point(12, 133);
            Studentnamelabel.Name = "Studentnamelabel";
            Studentnamelabel.Size = new Size(327, 38);
            Studentnamelabel.TabIndex = 2;
            Studentnamelabel.Text = "Enter A Student Name :";
            // 
            // StudentNameTextbox
            // 
            StudentNameTextbox.Location = new Point(355, 144);
            StudentNameTextbox.Name = "StudentNameTextbox";
            StudentNameTextbox.Size = new Size(272, 27);
            StudentNameTextbox.TabIndex = 3;
            // 
            // AddStudentButton
            // 
            AddStudentButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddStudentButton.Location = new Point(286, 229);
            AddStudentButton.Name = "AddStudentButton";
            AddStudentButton.Size = new Size(247, 56);
            AddStudentButton.TabIndex = 6;
            AddStudentButton.Text = "Add Student";
            AddStudentButton.UseVisualStyleBackColor = true;
            AddStudentButton.Click += AddStudentButton_Click;
            // 
            // AddStudent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(804, 387);
            Controls.Add(AddStudentButton);
            Controls.Add(StudentNameTextbox);
            Controls.Add(Studentnamelabel);
            Controls.Add(StudentIdTextbox);
            Controls.Add(StudentIdlabel);
            Name = "AddStudent";
            Text = "AddStudent";
            Load += AddStudent_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label StudentIdlabel;
        private TextBox StudentIdTextbox;
        private Label Studentnamelabel;
        private TextBox StudentNameTextbox;
        private Label EnrolledCoursesLabel;
        private TextBox EnrolledCoursesTextbox;
        private Button AddStudentButton;
    }
}