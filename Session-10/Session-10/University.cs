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
			Person professor1 = new Professor()
			{
				Name = "Fotis",
				Age = 43,
				Rank = "Associate",
                //Courses=Courses.Add(course1)
                //Courses=Courses.Add(course2)
            };
			Person professor2= new Professor()
			{
                Name = "Dimitris",
                Age = 40,
                Rank = "Assistant"
                //Courses=Courses.Add(course3)
                //Courses=Courses.Add(course4)
            };
			Person student1 = new Student()
			{
				Name = "Vlasis",
				Age = 29,
				RegistrationNumber= 1,
                //Courses=Courses.Add(course1)
                //Courses=Courses.Add(course3)
            };
			Person student2= new Student()
			{
				Name="George",
				Age= 26,
				RegistrationNumber= 2,
                //Courses=Courses.Add(course2)
                //Courses=Courses.Add(course4)
            };
			Grade grade1 = new Grade()
			{

			};
			Grade grade2 = new Grade()
			{

			};
			Schedule schedule1 = new Schedule()
			{

			};
			Schedule schedule2 = new Schedule()
			{

			};
			Course course1 = new Course() 
			{ 
				Code="1",
				Subject="C#",
			};
			Course course2 = new Course() 
			{
				Code="2",
				Subject="Git"
			};
			Course course3 = new Course()
			{
				Code = "3",
				Subject="VS"
			};
			Course course4 = new Course() 
			{
				Code="4",
				Subject="Windows Applications"
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
