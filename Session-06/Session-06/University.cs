using System;

namespace Session-06
{

	public class University : Institute
	{
		public Student[] Student { get; set; }
		public Course[] Course { get; set; }
		public Grade[] Grade { get; set; }
		public Schedule[] Schedule { get; set; }
		public University()
		{

		}
		public University(Guid id) : base(id)
		{

		}
		public University(Guid id,string name) : base(id,name)
		{

		}
		public University(Guid id, string name) : base(id, name)
		{

		}
		public University(Guid id, string name, int yearsInService) : base(id, name,yearsInService)
		{

		}
		public University(Guid id, string name, int yearsInService,Student student) : base(id, name, yearsInService)
		{
			Student= student;
		}
		public University(Guid id, string name, int yearsInService, Student student, Course course) : base(id, name, yearsInService)
		{
			Student = student;
			Course= course;
		}
		public University(Guid id, string name, int yearsInService, Student student, Course course,Grade grade) : base(id, name, yearsInService)
		{
			Student = student;
			Course = course;
			Grade= grade;
		}
		public University(Guid id, string name, int yearsInService, Student student, Course course, Grade grade,Scedule sceduledCourse) : base(id, name, yearsInService)
		{
			Student = student;
			Course = course;
			Grade = grade;
			Schedule= sceduledCourse;
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
