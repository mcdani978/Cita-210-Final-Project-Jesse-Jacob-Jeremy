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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void AddStudent_Load(object sender, EventArgs e)
        {

        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            // Get the student ID and name from the text boxes
            string StudentID = StudentIdTextbox.Text;
            string StudentName = StudentNameTextbox.Text;

            // Check if the text boxes are not empty
            if (!string.IsNullOrEmpty(StudentID) && !string.IsNullOrEmpty(StudentName))
            {
                // Check if a student with the same ID already exists
                if (MainMenu.Students.Any(s => s.StudentID == StudentID))
                {
                    // Show an error message if a student with the same ID exists
                    MessageBox.Show("A student with this ID already exists.");
                }
                else
                {
                    // Create a new StudentDatabase instance
                    MainMenu.StudentDatabase newStudent = new MainMenu.StudentDatabase
                    {
                        StudentID = StudentID,
                        StudentName = StudentName
                    };

                    // Add the new student to the Students list
                    MainMenu.Students.Add(newStudent);

                    // Save the new student's information to the settings
                    Properties.Settings.Default["StudentName"] = StudentName;
                    Properties.Settings.Default["StudentID"] = StudentID;
                    Properties.Settings.Default.Save(); // Don't forget to save the settings

                    // Show a message box to confirm the addition
                    MessageBox.Show("Student added successfully.");

                    // Clear the text boxes
                    StudentIdTextbox.Clear();
                    StudentNameTextbox.Clear();
                }
            }
            else
            {
                // Show a Message box if the text boxes are empty
                MessageBox.Show("Please enter a StudentID and Name.");
            }
        }

    }
}
