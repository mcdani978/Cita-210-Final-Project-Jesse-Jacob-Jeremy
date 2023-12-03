namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            studentToolStripMenuItem = new ToolStripMenuItem();
            addStudentToolStripMenuItem = new ToolStripMenuItem();
            viewStudentsToolStripMenuItem = new ToolStripMenuItem();
            searchForStudentsToolStripMenuItem = new ToolStripMenuItem();
            removeAStudentToolStripMenuItem = new ToolStripMenuItem();
            classToolStripMenuItem = new ToolStripMenuItem();
            addNewClassToolStripMenuItem = new ToolStripMenuItem();
            viewAllClassesToolStripMenuItem = new ToolStripMenuItem();
            searchForClassesToolStripMenuItem = new ToolStripMenuItem();
            removeAClassToolStripMenuItem = new ToolStripMenuItem();
            enrollToolStripMenuItem = new ToolStripMenuItem();
            enrollStudentsInCoursesToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Location = new Point(0, 30);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 3, 0, 3);
            menuStrip1.Size = new Size(610, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(20, 20);
            menuStrip2.Items.AddRange(new ToolStripItem[] { studentToolStripMenuItem, classToolStripMenuItem, enrollToolStripMenuItem, exitToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(10, 3, 0, 3);
            menuStrip2.Size = new Size(610, 30);
            menuStrip2.TabIndex = 1;
            menuStrip2.Text = "menuStrip2";
            // 
            // studentToolStripMenuItem
            // 
            studentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addStudentToolStripMenuItem, viewStudentsToolStripMenuItem, searchForStudentsToolStripMenuItem, removeAStudentToolStripMenuItem });
            studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            studentToolStripMenuItem.Size = new Size(74, 24);
            studentToolStripMenuItem.Text = "Student";
            studentToolStripMenuItem.Click += studentToolStripMenuItem_Click;
            // 
            // addStudentToolStripMenuItem
            // 
            addStudentToolStripMenuItem.Name = "addStudentToolStripMenuItem";
            addStudentToolStripMenuItem.Size = new Size(220, 26);
            addStudentToolStripMenuItem.Text = "Add Student";
            addStudentToolStripMenuItem.Click += addStudentToolStripMenuItem_Click;
            // 
            // viewStudentsToolStripMenuItem
            // 
            viewStudentsToolStripMenuItem.Name = "viewStudentsToolStripMenuItem";
            viewStudentsToolStripMenuItem.Size = new Size(220, 26);
            viewStudentsToolStripMenuItem.Text = "View Students";
            viewStudentsToolStripMenuItem.Click += viewStudentsToolStripMenuItem_Click;
            // 
            // searchForStudentsToolStripMenuItem
            // 
            searchForStudentsToolStripMenuItem.Name = "searchForStudentsToolStripMenuItem";
            searchForStudentsToolStripMenuItem.Size = new Size(220, 26);
            searchForStudentsToolStripMenuItem.Text = "Search for Students";
            searchForStudentsToolStripMenuItem.Click += searchForStudentsToolStripMenuItem_Click;
            // 
            // removeAStudentToolStripMenuItem
            // 
            removeAStudentToolStripMenuItem.Name = "removeAStudentToolStripMenuItem";
            removeAStudentToolStripMenuItem.Size = new Size(220, 26);
            removeAStudentToolStripMenuItem.Text = "Remove A Student";
            removeAStudentToolStripMenuItem.Click += removeAStudentToolStripMenuItem_Click;
            // 
            // classToolStripMenuItem
            // 
            classToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewClassToolStripMenuItem, viewAllClassesToolStripMenuItem, searchForClassesToolStripMenuItem, removeAClassToolStripMenuItem });
            classToolStripMenuItem.Name = "classToolStripMenuItem";
            classToolStripMenuItem.Size = new Size(56, 24);
            classToolStripMenuItem.Text = "Class";
            classToolStripMenuItem.Click += classToolStripMenuItem_Click;
            // 
            // addNewClassToolStripMenuItem
            // 
            addNewClassToolStripMenuItem.Name = "addNewClassToolStripMenuItem";
            addNewClassToolStripMenuItem.Size = new Size(224, 26);
            addNewClassToolStripMenuItem.Text = "Add new Class";
            addNewClassToolStripMenuItem.Click += addNewClassToolStripMenuItem_Click;
            // 
            // viewAllClassesToolStripMenuItem
            // 
            viewAllClassesToolStripMenuItem.Name = "viewAllClassesToolStripMenuItem";
            viewAllClassesToolStripMenuItem.Size = new Size(224, 26);
            viewAllClassesToolStripMenuItem.Text = "View All Classes";
            viewAllClassesToolStripMenuItem.Click += viewAllClassesToolStripMenuItem_Click;
            // 
            // searchForClassesToolStripMenuItem
            // 
            searchForClassesToolStripMenuItem.Name = "searchForClassesToolStripMenuItem";
            searchForClassesToolStripMenuItem.Size = new Size(224, 26);
            searchForClassesToolStripMenuItem.Text = "Search For Classes";
            searchForClassesToolStripMenuItem.Click += searchForClassesToolStripMenuItem_Click;
            // 
            // removeAClassToolStripMenuItem
            // 
            removeAClassToolStripMenuItem.Name = "removeAClassToolStripMenuItem";
            removeAClassToolStripMenuItem.Size = new Size(224, 26);
            removeAClassToolStripMenuItem.Text = "Remove A Class";
            removeAClassToolStripMenuItem.Click += removeAClassToolStripMenuItem_Click;
            // 
            // enrollToolStripMenuItem
            // 
            enrollToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { enrollStudentsInCoursesToolStripMenuItem });
            enrollToolStripMenuItem.Name = "enrollToolStripMenuItem";
            enrollToolStripMenuItem.Size = new Size(61, 24);
            enrollToolStripMenuItem.Text = "Enroll";
            // 
            // enrollStudentsInCoursesToolStripMenuItem
            // 
            enrollStudentsInCoursesToolStripMenuItem.Name = "enrollStudentsInCoursesToolStripMenuItem";
            enrollStudentsInCoursesToolStripMenuItem.Size = new Size(262, 26);
            enrollStudentsInCoursesToolStripMenuItem.Text = "Enroll Students In Courses";
            enrollStudentsInCoursesToolStripMenuItem.Click += enrollStudentsInCoursesToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(47, 24);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 179);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(567, 31);
            label1.TabIndex = 2;
            label1.Text = "CITA 210 Final Project Sample Database Application";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 238);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(278, 31);
            label2.TabIndex = 3;
            label2.Text = "Jesse, Jeremy, And Jacob";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(14F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 493);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(5, 5, 5, 5);
            Name = "MainMenu";
            Text = "Main Menu";
            Load += Form1_Load;
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem studentToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem viewStudentsToolStripMenuItem;
        private ToolStripMenuItem searchForStudentsToolStripMenuItem;
        private ToolStripMenuItem classToolStripMenuItem;
        private ToolStripMenuItem addNewClassToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem enrollToolStripMenuItem;
        private ToolStripMenuItem enrollStudentsInCoursesToolStripMenuItem;
        private ToolStripMenuItem viewAllClassesToolStripMenuItem;
        private ToolStripMenuItem searchForClassesToolStripMenuItem;
        private ToolStripMenuItem removeAStudentToolStripMenuItem;
        private ToolStripMenuItem removeAClassToolStripMenuItem;
        private Label label1;
        private Label label2;
    }
}