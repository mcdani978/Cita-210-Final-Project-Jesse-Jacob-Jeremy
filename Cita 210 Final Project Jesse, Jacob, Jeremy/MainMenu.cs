using Newtonsoft.Json;
using System.IO;

namespace Cita_210_Final_Project_Jesse__Jacob__Jeremy
{
    public partial class MainMenu : Form
    {
        public class StudentDatabase
        {
            public string StudentName { get; set; }
            public string StudentID { get; set; }
            public string[] CoursesEnrolledIn { get; set; }

            public override string ToString()
            {
                string courses = CoursesEnrolledIn != null && CoursesEnrolledIn.Length > 0 ? string.Join(", ", CoursesEnrolledIn) : "Not enrolled in any courses";
                return $"Student Name: {StudentName}, Student ID: {StudentID}, Courses Enrolled In: {courses}";
            }
        }

        public static List<StudentDatabase> Students = new List<StudentDatabase>();

        public class Course
        {
            public string CourseName { get; set; }
            public string CourseID { get; set; }
        }

        public static List<Course> Courses = new List<Course>();

        public MainMenu()
        {
            InitializeComponent();

            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
        }

       

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Serialize the Students list and save it to a file
            string studentsJson = JsonConvert.SerializeObject(Students);
            File.WriteAllText("students.json", studentsJson);

            // Only save the last student's information to the settings if the Students list is not empty
            if (Students.Any())
            {
                Properties.Settings.Default["StudentName"] = Students.Last().StudentName;
                Properties.Settings.Default["StudentID"] = Students.Last().StudentID;
                Properties.Settings.Default["CoursesEnrolledIn"] = Students.Last().CoursesEnrolledIn != null ? string.Join(",", Students.Last().CoursesEnrolledIn) : null;
            }
            else
            {
                Properties.Settings.Default["StudentName"] = null;
                Properties.Settings.Default["StudentID"] = null;
                Properties.Settings.Default["CoursesEnrolledIn"] = null;
            }

            // Serialize the Courses list and save it to a file
            string coursesJson = JsonConvert.SerializeObject(Courses);
            File.WriteAllText("courses.json", coursesJson);

            // Only save the last course's information to the settings if the Courses list is not empty
            if (Courses.Any())
            {
                Properties.Settings.Default["CourseName"] = Courses.Last().CourseName;
                Properties.Settings.Default["CourseID"] = Courses.Last().CourseID;
            }
            else
            {
                Properties.Settings.Default["CourseName"] = null;
                Properties.Settings.Default["CourseID"] = null;
            }

            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Load the Students list from a file and deserialize it
            if (File.Exists("students.json"))
            {
                string studentsJson = File.ReadAllText("students.json");
                Students = JsonConvert.DeserializeObject<List<StudentDatabase>>(studentsJson);
            }

            // Load the student's information from the settings
            string StudentName = (string)Properties.Settings.Default["StudentName"];
            string StudentID = (string)Properties.Settings.Default["StudentID"];
            string[] CoursesEnrolledIn = ((string)Properties.Settings.Default["CoursesEnrolledIn"])?.Split(',');

            // Create a new StudentDatabase instance with the loaded data
            StudentDatabase student = new StudentDatabase
            {
                StudentName = StudentName,
                StudentID = StudentID,
                CoursesEnrolledIn = CoursesEnrolledIn
            };

            // Check if the student is already in the Students list
            if (!Students.Any(s => s.StudentID == student.StudentID))
            {
                // Add the student to the Students list
                Students.Add(student);
            }

            // Load the Courses list from a file and deserialize it
            if (File.Exists("courses.json"))
            {
                string coursesJson = File.ReadAllText("courses.json");
                Courses = JsonConvert.DeserializeObject<List<Course>>(coursesJson);
            }

            // Load the course's information from the settings
            string CourseName = (string)Properties.Settings.Default["CourseName"];
            string CourseID = (string)Properties.Settings.Default["CourseID"];

            // Only create a new Course object and add it to the Courses list if the CourseName and CourseID settings are not empty
            if (!string.IsNullOrEmpty(CourseName) && !string.IsNullOrEmpty(CourseID))
            {
                // Create a new Course instance with the loaded data
                Course course = new Course
                {
                    CourseName = CourseName,
                    CourseID = CourseID
                };

                // Check if the course is already in the Courses list
                if (!Courses.Any(c => c.CourseID == course.CourseID))
                {
                    // Add the course to the Courses list
                    Courses.Add(course);
                }
            }
        }



        private void searchForStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForStudents searchForStudents = new SearchForStudents();
            searchForStudents.Show();
        }

        private void classToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddStudent addStudent = new AddStudent();
            addStudent.Show();
        }

        private void studentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewStudents viewStudents = new ViewStudents();
            viewStudents.Show();
        }

        private void addNewClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewClass addNewClass = new AddNewClass();
            addNewClass.Show();
        }

        private void enrollStudentsInCoursesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EnrollStudentsInCourses enrollStudentsInCourses = new EnrollStudentsInCourses();
            enrollStudentsInCourses.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewAllClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllClasses viewAllClasses = new ViewAllClasses();
            viewAllClasses.Show();
        }

        private void searchForClassesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForClasses searchForClasses = new SearchForClasses();
            searchForClasses.Show();
        }

        private void removeAStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_A_Student remove_A_Student = new Remove_A_Student();
            remove_A_Student.Show();
        }

        private void removeAClassToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_A_Class remove_A_Class = new Remove_A_Class();
            remove_A_Class.Show();
        }
    }
}