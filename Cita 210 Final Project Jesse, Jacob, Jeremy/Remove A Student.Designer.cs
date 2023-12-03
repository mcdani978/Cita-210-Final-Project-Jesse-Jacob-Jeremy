namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    partial class Remove_A_Student
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
            EnterAStudentIdLabel = new Label();
            EnterAStudentIdTextbox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // EnterAStudentIdLabel
            // 
            EnterAStudentIdLabel.AutoSize = true;
            EnterAStudentIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EnterAStudentIdLabel.Location = new Point(12, 32);
            EnterAStudentIdLabel.Name = "EnterAStudentIdLabel";
            EnterAStudentIdLabel.Size = new Size(279, 38);
            EnterAStudentIdLabel.TabIndex = 0;
            EnterAStudentIdLabel.Text = "Enter A Student ID :";
            // 
            // EnterAStudentIdTextbox
            // 
            EnterAStudentIdTextbox.Location = new Point(297, 43);
            EnterAStudentIdTextbox.Name = "EnterAStudentIdTextbox";
            EnterAStudentIdTextbox.Size = new Size(308, 27);
            EnterAStudentIdTextbox.TabIndex = 1;
            EnterAStudentIdTextbox.TextChanged += EnterAStudentIdTextbox_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(197, 127);
            button1.Name = "button1";
            button1.Size = new Size(267, 60);
            button1.TabIndex = 2;
            button1.Text = "Remove Student";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Remove_A_Student
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(679, 234);
            Controls.Add(button1);
            Controls.Add(EnterAStudentIdTextbox);
            Controls.Add(EnterAStudentIdLabel);
            Name = "Remove_A_Student";
            Text = "Remove A Student";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EnterAStudentIdLabel;
        private TextBox EnterAStudentIdTextbox;
        private Button button1;
    }
}