namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    partial class SearchForStudents
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
            SearchForStudentsIdLabel = new Label();
            SearchForStudentsIdTextbox = new TextBox();
            dataGridView1 = new DataGridView();
            SearchForStudentsButton = new Button();
            AndOrlabel = new Label();
            SearchForStudentsNameLabel = new Label();
            SearchForStudentsNameTextbox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // SearchForStudentsIdLabel
            // 
            SearchForStudentsIdLabel.AutoSize = true;
            SearchForStudentsIdLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SearchForStudentsIdLabel.Location = new Point(12, 21);
            SearchForStudentsIdLabel.Name = "SearchForStudentsIdLabel";
            SearchForStudentsIdLabel.Size = new Size(279, 38);
            SearchForStudentsIdLabel.TabIndex = 0;
            SearchForStudentsIdLabel.Text = "Enter A Student ID :";
            SearchForStudentsIdLabel.Click += label1_Click;
            // 
            // SearchForStudentsIdTextbox
            // 
            SearchForStudentsIdTextbox.Location = new Point(297, 32);
            SearchForStudentsIdTextbox.Name = "SearchForStudentsIdTextbox";
            SearchForStudentsIdTextbox.Size = new Size(339, 27);
            SearchForStudentsIdTextbox.TabIndex = 1;
            SearchForStudentsIdTextbox.TextChanged += SearchForStudentsTextbox_TextChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(40, 209);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(557, 93);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // SearchForStudentsButton
            // 
            SearchForStudentsButton.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            SearchForStudentsButton.Location = new Point(87, 334);
            SearchForStudentsButton.Name = "SearchForStudentsButton";
            SearchForStudentsButton.Size = new Size(452, 70);
            SearchForStudentsButton.TabIndex = 3;
            SearchForStudentsButton.Text = "Search For Students";
            SearchForStudentsButton.UseVisualStyleBackColor = true;
            SearchForStudentsButton.Click += SearchForStudentsButton_Click;
            // 
            // AndOrlabel
            // 
            AndOrlabel.AutoSize = true;
            AndOrlabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            AndOrlabel.Location = new Point(257, 79);
            AndOrlabel.Name = "AndOrlabel";
            AndOrlabel.Size = new Size(111, 38);
            AndOrlabel.TabIndex = 4;
            AndOrlabel.Text = "And Or";
            // 
            // SearchForStudentsNameLabel
            // 
            SearchForStudentsNameLabel.AutoSize = true;
            SearchForStudentsNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SearchForStudentsNameLabel.Location = new Point(12, 141);
            SearchForStudentsNameLabel.Name = "SearchForStudentsNameLabel";
            SearchForStudentsNameLabel.Size = new Size(327, 38);
            SearchForStudentsNameLabel.TabIndex = 5;
            SearchForStudentsNameLabel.Text = "Enter A Student Name :";
            // 
            // SearchForStudentsNameTextbox
            // 
            SearchForStudentsNameTextbox.Location = new Point(335, 152);
            SearchForStudentsNameTextbox.Name = "SearchForStudentsNameTextbox";
            SearchForStudentsNameTextbox.Size = new Size(301, 27);
            SearchForStudentsNameTextbox.TabIndex = 6;
            SearchForStudentsNameTextbox.TextChanged += SearchForStudentsNameTextbox_TextChanged;
            // 
            // SearchForStudents
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 434);
            Controls.Add(SearchForStudentsNameTextbox);
            Controls.Add(SearchForStudentsNameLabel);
            Controls.Add(AndOrlabel);
            Controls.Add(SearchForStudentsButton);
            Controls.Add(dataGridView1);
            Controls.Add(SearchForStudentsIdTextbox);
            Controls.Add(SearchForStudentsIdLabel);
            Name = "SearchForStudents";
            Text = "SearchForStudents";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label SearchForStudentsIdLabel;
        private TextBox SearchForStudentsIdTextbox;
        private DataGridView dataGridView1;
        private Button SearchForStudentsButton;
        private Label AndOrlabel;
        private Label SearchForStudentsNameLabel;
        private TextBox SearchForStudentsNameTextbox;
    }
}