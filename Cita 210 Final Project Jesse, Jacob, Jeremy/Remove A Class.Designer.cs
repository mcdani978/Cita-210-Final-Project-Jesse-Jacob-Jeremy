namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    partial class Remove_A_Class
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
            EnterAClassIDLabel = new Label();
            EnterAClassIdTextbox = new TextBox();
            RemoveClassButton = new Button();
            SuspendLayout();
            // 
            // EnterAClassIDLabel
            // 
            EnterAClassIDLabel.AutoSize = true;
            EnterAClassIDLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            EnterAClassIDLabel.Location = new Point(12, 31);
            EnterAClassIDLabel.Name = "EnterAClassIDLabel";
            EnterAClassIDLabel.Size = new Size(240, 38);
            EnterAClassIDLabel.TabIndex = 0;
            EnterAClassIDLabel.Text = "Enter A Class ID :";
            // 
            // EnterAClassIdTextbox
            // 
            EnterAClassIdTextbox.Location = new Point(258, 42);
            EnterAClassIdTextbox.Name = "EnterAClassIdTextbox";
            EnterAClassIdTextbox.Size = new Size(245, 27);
            EnterAClassIdTextbox.TabIndex = 1;
            EnterAClassIdTextbox.TextChanged += EnterAClassIdTextbox_TextChanged;
            // 
            // RemoveClassButton
            // 
            RemoveClassButton.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            RemoveClassButton.Location = new Point(167, 141);
            RemoveClassButton.Name = "RemoveClassButton";
            RemoveClassButton.Size = new Size(220, 53);
            RemoveClassButton.TabIndex = 2;
            RemoveClassButton.Text = "Remove Class";
            RemoveClassButton.UseVisualStyleBackColor = true;
            RemoveClassButton.Click += RemoveClassButton_Click;
            // 
            // Remove_A_Class
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 264);
            Controls.Add(RemoveClassButton);
            Controls.Add(EnterAClassIdTextbox);
            Controls.Add(EnterAClassIDLabel);
            Name = "Remove_A_Class";
            Text = "Remove A Class";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label EnterAClassIDLabel;
        private TextBox EnterAClassIdTextbox;
        private Button RemoveClassButton;
    }
}