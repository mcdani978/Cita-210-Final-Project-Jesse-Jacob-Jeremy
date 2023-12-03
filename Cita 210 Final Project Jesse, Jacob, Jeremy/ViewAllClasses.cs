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
    public partial class ViewAllClasses : Form
    {
        public ViewAllClasses()
        {
            InitializeComponent();

            // Create a new DataTable
            DataTable dt = new DataTable();

            // Add Columns to the Datatable
            dt.Columns.Add("Course Name");

            dt.Columns.Add("Course ID");

            // Add rows to the DataTable for each student
            foreach (var course in MainMenu.Courses)
            {
                dt.Rows.Add(course.CourseID, course.CourseName);
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
    }
}
