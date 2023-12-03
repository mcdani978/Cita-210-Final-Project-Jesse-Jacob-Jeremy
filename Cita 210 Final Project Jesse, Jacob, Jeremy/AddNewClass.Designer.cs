namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    partial class AddNewClass
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
            CourseNameTextBox = new TextBox();
            CourseNameLabel = new Label();
            AddNewClassButton = new Button();
            CourseIdLabel = new Label();
            CourseIDTextbox = new TextBox();
            SuspendLayout();
            // 
            // CourseNameTextBox
            // 
            CourseNameTextBox.Location = new Point(377, 58);
            CourseNameTextBox.Name = "CourseNameTextBox";
            CourseNameTextBox.Size = new Size(199, 27);
            CourseNameTextBox.TabIndex = 0;
            CourseNameTextBox.TextChanged += CourseNameTextBox_TextChanged;
            // 
            // CourseNameLabel
            // 
            CourseNameLabel.AutoSize = true;
            CourseNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CourseNameLabel.Location = new Point(0, 47);
            CourseNameLabel.Name = "CourseNameLabel";
            CourseNameLabel.Size = new Size(380, 38);
            CourseNameLabel.TabIndex = 1;
            CourseNameLabel.Text = "Enter A New Course Name :";
            // 
            // AddNewClassButton
            // 
            AddNewClassButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AddNewClassButton.Location = new Point(159, 208);
            AddNewClassButton.Name = "AddNewClassButton";
            AddNewClassButton.Size = new Size(247, 65);
            AddNewClassButton.TabIndex = 4;
            AddNewClassButton.Text = "Add New Class";
            AddNewClassButton.UseVisualStyleBackColor = true;
            AddNewClassButton.Click += AddNewClassButton_Click;
            // 
            // CourseIdLabel
            // 
            CourseIdLabel.AutoSize = true;
            CourseIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            CourseIdLabel.Location = new Point(0, 117);
            CourseIdLabel.Name = "CourseIdLabel";
            CourseIdLabel.Size = new Size(332, 38);
            CourseIdLabel.TabIndex = 2;
            CourseIdLabel.Text = "Enter A New Course ID :";
            CourseIdLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // CourseIDTextbox
            // 
            CourseIDTextbox.Location = new Point(329, 128);
            CourseIDTextbox.Name = "CourseIDTextbox";
            CourseIDTextbox.Size = new Size(204, 27);
            CourseIDTextbox.TabIndex = 3;
            CourseIDTextbox.TextChanged += CourseIDTextbox_TextChanged;
            // 
            // AddNewClass
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(597, 322);
            Controls.Add(AddNewClassButton);
            Controls.Add(CourseIDTextbox);
            Controls.Add(CourseIdLabel);
            Controls.Add(CourseNameLabel);
            Controls.Add(CourseNameTextBox);
            Name = "AddNewClass";
            Text = "AddNewClass";
            Load += AddNewClass_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox CourseNameTextBox;
        private Label CourseNameLabel;
        private Button AddNewClassButton;
        private Label CourseIdLabel;
        private TextBox CourseIDTextbox;
    }
}