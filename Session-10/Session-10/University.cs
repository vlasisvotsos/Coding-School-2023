using System;

namespace Session_10
{

	public class University : Institute
	{
		public List <Student> Students { get; set; }
		public List<Course> Courses { get; set; }
		public List <Grade> Grades { get; set; }
		public List<Schedule> Schedules { get; set; }
		public University()
		{
            Course course1 = new Course()
            {
                Code = "1",
                Subject = "C#"
            };
            Course course2 = new Course()
            {
                Code = "2",
                Subject = "Git"
            };
            Course course3 = new Course()
            {
                Code = "3",
                Subject = "VS"
            };
            Course course4 = new Course()
            {
                Code = "4",
                Subject = "Windows Applications"
            };
			Courses.Add(course1);
			Courses.Add(course2);
			Courses.Add(course3);
			Courses.Add(course4);
			Person professor1 = new Professor(Courses)
			{
				Name = "Fotis",
				Age = 43,
				Rank = "Associate",
				Courses = Courses
            };
			Person professor2= new Professor(Courses)
			{
                Name = "Dimitris",
                Age = 40,
                Rank = "Assistant"
            };
			Person student1 = new Student(Courses)
			{
				Name = "Vlasis",
				Age = 29,
				RegistrationNumber= 1
            };
			Person student2= new Student(Courses)
			{
				Name="George",
				Age= 26,
				RegistrationNumber= 2
            };
			Grade grade1 = new Grade(student1.ID,course1.ID)
			{
				Grades=7
			};
			Grade grade2 = new Grade(student1.ID,course3.ID)
			{
				Grades=9
			};
			Grade grade3 = new Grade(student2.ID,course2.ID)
			{
				Grades =6
			};
			Grade grade4 = new Grade(student2.ID, course4.ID)
			{
				Grades=8
			};
			Schedule schedule1 = new Schedule(course1.ID,professor1.ID)
			{
				Callender= DateTime.Now
			};
			Schedule schedule2 = new Schedule(course2.ID,professor1.ID)
			{
				Callender= DateTime.Now
			};
			Schedule schedule3 = new Schedule(course3.ID, professor2.ID)
			{
				Callender = DateTime.Now
            };
			Schedule schedule4 = new Schedule(course4.ID, professor2.ID)
			{
				Callender = DateTime.Now
            };
			
		}		
		public void GetStudents()
		{

		}
		public void GetCourses()
		{

		}
		public void GetGrades()
		{

		}
	}

}
