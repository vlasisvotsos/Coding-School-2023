using System;

namespace Session_10
{
	public class Student : Person
	{
		public int RegistrationNumber { get; set; }
		public List<Course> Courses { get; set; }
		public Student()
		{
            
        }
        public void Attend(Course course, DateTime date)
		{

		}
		public void WriteExam(Course course, DateTime date)
		{

		}
	}
}
