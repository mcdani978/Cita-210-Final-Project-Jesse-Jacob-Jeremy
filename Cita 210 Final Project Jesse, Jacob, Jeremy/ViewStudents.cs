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
    public partial class ViewStudents : Form
    {
        public ViewStudents()
        {
            InitializeComponent();

            // Create a new DataTable
            DataTable dt = new DataTable();

            // Add Columns to the DataTable
            dt.Columns.Add("Student ID");
            dt.Columns.Add("Student Name");
            dt.Columns.Add("Courses Enrolled In");

            // Add rows to the DataTable for each student 
            foreach (var student in MainMenu.Students)
            {
                // Only add the student to the DataTable if the StudentName and StudentID are not empty
                if (!string.IsNullOrEmpty(student.StudentName) && !string.IsNullOrEmpty(student.StudentID))
                {
                    string courses = student.CoursesEnrolledIn != null && student.CoursesEnrolledIn.Length > 0
                        ? string.Join(", ", student.CoursesEnrolledIn) : "Not enrolled in any courses";

                    dt.Rows.Add(student.StudentID, student.StudentName, courses);
                }
            }

            // Bind the DataTable to the DataGridView 
            dataGridView1.DataSource = dt;

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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
