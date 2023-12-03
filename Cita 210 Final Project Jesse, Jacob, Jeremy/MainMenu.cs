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

        }

        private void Form1_Load(object sender, EventArgs e)
        {

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