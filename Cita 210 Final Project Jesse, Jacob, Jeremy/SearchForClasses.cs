using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Cita_210_Final_Project_Jesse__Jacob__Jeremy.MainMenu;

namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    public partial class SearchForClasses : Form
    {
        public SearchForClasses()
        {
            InitializeComponent();

            // Set the TextBox to use the Suggest AutoComplete mode
            CourseNameTextbox.AutoCompleteMode = AutoCompleteMode.Suggest;

            // Set the TextBox to get the AutoComplete values from a custom source
            CourseNameTextbox.AutoCompleteSource = AutoCompleteSource.CustomSource;

            // Create a new AutoCompleteStringCollection
            AutoCompleteStringCollection autoComplete = new AutoCompleteStringCollection();

            // Add the names of all the students to the AutoCompleteStringCollection
            foreach (var Course in MainMenu.Courses)
            {
                autoComplete.Add(Course.CourseName);
            }

            // Set the TextBox's AutoCompleteCustomSource to the AutoCompleteStringCollection
            CourseNameTextbox.AutoCompleteCustomSource = autoComplete;

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

        private void SearchForCourseButton_Click(object sender, EventArgs e)
        {
            // Get the Course ID and name from the text boxes
            string CourseID = CourseIdTextBox.Text;
            string CourseName = CourseNameTextbox.Text;

            // Search for the course in the course list
            var Course = MainMenu.Courses.FirstOrDefault(s => s.CourseID == CourseID || s.CourseName == CourseName);

            // If the Course was found
            if (Course != null)
            {
                // Create a new datatable 
                DataTable dt = new DataTable();

                // Add columns to the DataTable
                dt.Columns.Add("Course ID");
                dt.Columns.Add("Course Name");

                // Add a row to the dataTable for the Course
                dt.Rows.Add(Course.CourseID, Course.CourseName);

                // Set the DataTable as the DataSource for your DataGridView
                dataGridView1.DataSource = dt;
            }
            else
            {
                // Show a message box if the course was not found
                MessageBox.Show("Course Not Found.");
            }
        }
    }
}
