using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    public partial class AddNewClass : Form
    {
        public AddNewClass()
        {
            InitializeComponent();
        }

        private void AddNewClass_Load(object sender, EventArgs e)
        {

        }

        private void AddNewClassButton_Click(object sender, EventArgs e)
        {
            // Get the course name and ID from the text boxes
            string courseName = CourseNameTextBox.Text;
            string courseID = CourseIDTextbox.Text;

            // Only create a new Course object and add it to the Courses list if the CourseName and CourseID text boxes are not empty
            if (!string.IsNullOrEmpty(courseName) && !string.IsNullOrEmpty(courseID))
            {
                // Check if a course with the same ID or name already exists
                if (MainMenu.Courses.Any(s => s.CourseID == courseID) || MainMenu.Courses.Any(s => s.CourseName == courseName))
                {
                    // Show an error message if a course with the same ID or name exists
                    MessageBox.Show("A Class with this ID or Name already exists");
                }
                else
                {
                    // Create a new Course instance
                    MainMenu.Course newCourse = new MainMenu.Course
                    {
                        CourseName = courseName,
                        CourseID = courseID
                    };

                    // Add the new course to the Courses list
                    MainMenu.Courses.Add(newCourse);

                    // Show a message box to confirm the addition
                    MessageBox.Show("Course added successfully.");

                    // Clear the text boxes
                    CourseNameTextBox.Clear();
                    CourseIDTextbox.Clear();
                }
            }
            else
            {
                // Show a message box if the text boxes are empty
                MessageBox.Show("Please enter a course name and ID.");
            }
        }


        private void CourseNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CourseIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
