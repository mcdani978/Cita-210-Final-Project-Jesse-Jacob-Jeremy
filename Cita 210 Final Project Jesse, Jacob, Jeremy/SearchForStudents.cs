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
    public partial class SearchForStudents : Form
    {
        public SearchForStudents()
        {
            InitializeComponent();

            // Set the TextBox to use the Suggest AutoComplete mode
            SearchForStudentsNameTextbox.AutoCompleteMode = AutoCompleteMode.Suggest;

            // Set the TextBox to get the AutoComplete values from a custom source
            SearchForStudentsNameTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Create a new AutoCompleteStringCollection
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            // Add the names of all the students to the AutoCompleteStringCollection
            foreach (var student in MainMenu.Students)
            {
                autoComplete.Add(student.StudentName);
            }

            // Enable cell tooltips
            dataGridView1.CellMouseEnter += (s, e) =>
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    dataGridView1.ShowCellToolTips = true;
                    if (cell.Value != null)
                    {
                        cell.ToolTipText = cell.Value.ToString();
                    }
                    else
                    {
                        cell.ToolTipText = "";
                    }
                }
            };

            // Set the TextBox's AutoCompleteCustomSource to the AutoCompleteStringCollection
            SearchForStudentsNameTextbox.AutoCompleteCustomSource = autoComplete;

            // Automatically resize the visible rows.
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;

            // Set the DataGridView control's border.
            dataGridView1.BorderStyle = BorderStyle.Fixed3D;

            // Put the cells in edit mode when user enters them.
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;

            // Resize columns to fit the content
            dataGridView1.AutoResizeColumns();

            // Set the DataGridView to fill the entire grid with the columns
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Hide the row headers
            dataGridView1.RowHeadersVisible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SearchForStudentsTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchForStudentsButton_Click(object sender, EventArgs e)
        {
            // Get the student ID and name from the text boxes
            string studentID = SearchForStudentsIdTextbox.Text;
            string studentName = SearchForStudentsNameTextbox.Text;

            // Search for the students in the Students list
            var students = MainMenu.Students.Where(s => s.StudentID == studentID || s.StudentName == studentName).ToList();

            // If any students were found
            if (students.Any())
            {
                // Create a new DataTable
                DataTable dt = new DataTable();

                // Add columns to the DataTable
                dt.Columns.Add("Student ID");
                dt.Columns.Add("Student Name");
                dt.Columns.Add("Courses Enrolled In");  // New column for the courses

                // Add a row to the DataTable for each student
                foreach (var student in students)
                {
                    string courses = student.CoursesEnrolledIn != null && student.CoursesEnrolledIn.Length > 0 ? string.Join(", ", student.CoursesEnrolledIn) : "Not enrolled in any courses";
                    dt.Rows.Add(student.StudentID, student.StudentName, courses);
                }

                // Bind the DataTable to the DataGridView
                dataGridView1.DataSource = dt;
            }
            else
            {
                // Show a message box if no students were found
                MessageBox.Show("Student not found.");
            }

        }

        private void SearchForStudentsNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
