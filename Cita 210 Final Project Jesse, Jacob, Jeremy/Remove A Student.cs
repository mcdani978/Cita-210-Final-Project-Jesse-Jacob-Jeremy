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
    public partial class Remove_A_Student : Form
    {
        public Remove_A_Student()
        {
            InitializeComponent();
        }

        private void EnterAStudentIdTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the student ID from the text box
            string studentID = EnterAStudentIdTextbox.Text;

            // Search for the student in the student list
            var student = MainMenu.Students.FirstOrDefault(s => s.StudentID == studentID);

            // If the student was found
            if (student != null)
            {
                // Remove the student from the list
                MainMenu.Students.Remove(student);

                // Show a message box indicating the student was removed
                MessageBox.Show("Student removed successfully.");
            }
            else
            {
                // Show a message box if the student was not found
                MessageBox.Show("Student not found.");
            }
        }
    }
}
