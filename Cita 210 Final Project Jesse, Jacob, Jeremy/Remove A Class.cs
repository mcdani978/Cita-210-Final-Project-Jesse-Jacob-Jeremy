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
    public partial class Remove_A_Class : Form
    {
        public Remove_A_Class()
        {
            InitializeComponent();
        }

        private void EnterAClassIdTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RemoveClassButton_Click(object sender, EventArgs e)
        {
            // Get the class ID from the text box
            string classID = EnterAClassIdTextbox.Text;

            // Search for the class in the class list
            var course = MainMenu.Courses.FirstOrDefault(c => c.CourseID == classID);

            // If the class was found
            if (course != null)
            {
                // Remove the class from the list
                MainMenu.Courses.Remove(course);

                // Show a message box indicating the class was removed
                MessageBox.Show("Class removed successfully.");
            }
            else
            {
                // Show a message box if the class was not found
                MessageBox.Show("Class not found.");
            }

        }
    }
}
