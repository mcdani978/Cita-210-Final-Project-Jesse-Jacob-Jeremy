using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    public partial class EnrollStudentsInCourses : Form
    {
        private List<string> selectedCourses = new List<string>();

        public EnrollStudentsInCourses()
        {
            InitializeComponent();

            // Set the ComboBox to use the DropDown style
            EnrollInCoursesComboBox.DropDownStyle = ComboBoxStyle.DropDown;

            // Enable the AutoComplete feature
            EnrollInCoursesComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            EnrollInCoursesComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;

            // Populate the ComboBox with the names of all the courses
            foreach (var course in MainMenu.Courses)
            {
                // Only add the course to the ComboBox if the CourseName is not empty
                if (!string.IsNullOrEmpty(course.CourseName))
                {
                    EnrollInCoursesComboBox.Items.Add(course.CourseName);
                }
            }
        }

        private void EnrollInCoursesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void StudentIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnrollStudentbutton_Click(object sender, EventArgs e)
        {
            {
                // Get the student ID from the TextBox
                string studentID = StudentIDTextbox.Text;

                // Check if the student ID is not empty
                if (!string.IsNullOrEmpty(studentID))
                {
                    // Find the student with the entered ID
                    var student = MainMenu.Students.FirstOrDefault(s => s.StudentID == studentID);

                    // If the student was found
                    if (student != null)
                    {
                        // Enroll the student in the selected courses
                        foreach (var course in selectedCourses)
                        {
                            // Check if the student is already enrolled in the course
                            if (student.CoursesEnrolledIn != null && student.CoursesEnrolledIn.Contains(course))
                            {
                                // Show an error message if the student is already enrolled in the course
                                MessageBox.Show($"Student is already enrolled in {course}.");
                            }
                            else
                            {
                                // Add the course to the student's CoursesEnrolledIn array
                                List<string> courses = new List<string>(student.CoursesEnrolledIn ?? new string[0]);
                                courses.Add(course);
                                student.CoursesEnrolledIn = courses.ToArray();

                                // Show a message box to confirm the enrollment
                                MessageBox.Show($"Student enrolled in {course}.");
                            }
                        }

                        // Clear the selected courses
                        selectedCourses.Clear();
                        CoursesEnrolledIntoListBox.Items.Clear();
                    }
                    else
                    {
                        // Show a message box if the student was not found
                        MessageBox.Show("Invalid student ID. Please enter a valid student ID.");
                    }
                }
                else
                {
                    // Show a message box if the student ID is empty
                    MessageBox.Show("Please enter a student ID.");
                }
            }
        }

        private void EnrollInCourseButton_Click(object sender, EventArgs e)
        {
            // Check if a course is selected in the ComboBox
            if (EnrollInCoursesComboBox.SelectedItem == null)
            {
                // Show a message box if no course is selected
                MessageBox.Show("Please select a course.");
                return;
            }

            // Get the selected course from the ComboBox
            string selectedCourse = EnrollInCoursesComboBox.SelectedItem.ToString();

            // Check if the course is already in the selectedCourses list
            if (selectedCourses.Contains(selectedCourse))
            {
                // Show an error message if the course is already in the list
                MessageBox.Show("Error: You have already added that course to the cart.");
            }
            else
            {
                // Add the selected course to the list of selected courses
                selectedCourses.Add(selectedCourse);

                // Add the selected course to the ListBox
                CoursesEnrolledIntoListBox.Items.Add(selectedCourse);
            }
        }

        private void ClearSelectedCoursesButton_Click(object sender, EventArgs e)
        {
            // Clear the list of selected courses
            selectedCourses.Clear();

            // Clear the ListBox
            CoursesEnrolledIntoListBox.Items.Clear();
        }

        private void CoursesEnrolledIntoListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
