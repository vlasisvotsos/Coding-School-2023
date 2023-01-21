using System;

namespace Session06
{

	public class University : Institute
	{
		public Student[] Students { get; set; }
		public Course[] Courses { get; set; }
		public Grade[] Grades { get; set; }
		public Schedule[] Schedules { get; set; }
		public University()
		{

		}
		public University(Guid id) : base(id)
		{

		}
		public University(Guid id,string name) : base(id,name)
		{

		}
		public University(Guid id, string name, int yearsInService) : base(id, name,yearsInService)
		{

		}
		public University(Guid id, string name, int yearsInService,Student[] students) : base(id, name, yearsInService)
		{
			Students= students;
		}
		public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses) : base(id, name, yearsInService)
		{
			Students = students;
			Courses= courses;
		}
		public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses,Grade[] grades) : base(id, name, yearsInService)
		{
			Students = students;
			Courses = courses;
			Grades= grades;
		}
		public University(Guid id, string name, int yearsInService, Student[] students, Course[] courses, Grade[] grades,Schedule[] sceduledCourses) : base(id, name, yearsInService)
		{
			Students = students;
			Courses = courses;
			Grades = grades;
			Schedules= sceduledCourses;
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
