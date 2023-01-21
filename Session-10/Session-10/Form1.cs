namespace Session_10
{
    public partial class Form1 : Form
    { 
        public Form1()
        {
            InitializeComponent();
            var Courses = this.Courses;
            var Students = this.Students;
            var Grades = this.Grades;
            var Schedules = this.Schedules;
            dataGridView1.DataSource = Courses;             
            dataGridView2.DataSource = Grades;           
            dataGridView3.DataSource = Schedules;
            dataGridView4.DataSource = Students;

        }
       static Course course1 = new Course()
        {
            Code = "1",
            Subject = "C#"
        };
       static Course course2 = new Course()
        {
            Code = "2",
            Subject = "Git"
        };
       static Course course3 = new Course()
        {
            Code = "3",
            Subject = "VS"
        };
       static Course course4 = new Course()
        {
            Code = "4",
            Subject = "Windows Applications"
        };

        List<Course> Courses = new List<Course>() {course1, course2, course3, course4};

        static Person professor1 = new Professor()
        {
            Name = "Fotis",
            Age = 43,
            Rank = "Associate",
            Courses = new List<Course>() { course1,course2 }
        };
        static Person professor2 = new Professor()
        {
            Name = "Dimitris",
            Age = 40,
            Rank = "Assistant",
            Courses= new List<Course>() { course3,course4}
        };

        List<Professor> Professors = new List<Professor>() { (Professor)professor1,(Professor)professor2};

        static Person student1 = new Student()
            {
                Name = "Vlasis",
                Age = 29,
                RegistrationNumber = 1,
                Courses=new List<Course>() { course1,course3 }
            };
        static Person student2 = new Student()
        {
            Name = "George",
            Age = 26,
            RegistrationNumber = 2,
            Courses=new List<Course>() { course2,course4 }
        };

        List<Student> Students = new List<Student>() { (Student)student1,(Student)student2};

        static Grade grade1 = new Grade(student1.ID, course1.ID)
            {
                Grades = 7
            };
        static Grade grade2 = new Grade(student1.ID, course3.ID)
        {
            Grades = 9
        };
        static Grade grade3 = new Grade(student2.ID, course2.ID)
        {
            Grades = 6
        };
        static Grade grade4 = new Grade(student2.ID, course4.ID)
        {
            Grades = 8
        };

        List<Grade> Grades = new List<Grade>() {grade1,grade2,grade3,grade4 };

        static Schedule schedule1 = new Schedule(course1.ID, professor1.ID)
            {
                Callender = DateTime.Now
            };
       static Schedule schedule2 = new Schedule(course2.ID, professor1.ID)
        {
            Callender = DateTime.Now
        };
        static Schedule schedule3 = new Schedule(course3.ID, professor2.ID)
        {
            Callender = DateTime.Now
        };
        static Schedule schedule4 = new Schedule(course4.ID, professor2.ID)
        {
            Callender = DateTime.Now
        };

        List<Schedule> Schedules = new List<Schedule>() {schedule1,schedule2,schedule3,schedule4 };


        University university = new University()
        {
            Students = new List<Student>() { (Student)student1, (Student)student2},
            Courses = new List<Course>() {course1, course2, course3, course4},
            Grades = new List<Grade>() { grade1,grade2, grade3, grade4},
            Schedules = new List<Schedule>() { schedule1,schedule2, schedule3, schedule4},
            Professors = new List<Professor>() {(Professor) professor1,(Professor)professor2}
        };

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //courses

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //grade
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //schedule
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //student
        }
    }
}