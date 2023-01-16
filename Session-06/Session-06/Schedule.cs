using System;

namespace Session06
{
	public class Schedule
	{
		public Guid Id { get; set; }
		public Guid CourseID { get; set; }
		public Guid ProfessorID { get; set; }
		public DateTime Callender { get; set; }
		public Schedule()
		{

		}
		public Schedule(Guid id)
		{
			Id = id;
		}
		public Schedule(Guid id,Guid courseID)
		{
			Id = id;
			CourseID = courseID;
		}
		public Schedule(Guid id, Guid courseID,Guid professorID)
		{
			Id = id;
			CourseID = courseID;
			ProfessorID= professorID;
		}
		public Schedule(Guid id, Guid courseID, Guid professorID,DateTime callender)
		{
			Id = id;
			CourseID = courseID;
			ProfessorID = professorID;
			Callender = callender;
		}
	}
}
