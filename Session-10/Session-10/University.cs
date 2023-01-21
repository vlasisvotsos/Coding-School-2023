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
			Person professor1 = new Professor();
			Person professor2= new Professor();
			Person student1= new Student();
			Person student2= new Student();
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
