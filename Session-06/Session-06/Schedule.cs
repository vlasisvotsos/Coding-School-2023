using System;

namespace Session06
{
	public class Schedule
	{
		public Guid ID { get; set; }
		public Guid CourseID { get; set; }
		public Guid ProfessorID { get; set; }
		public DateTime Callender { get; set; }
		public Schedule()
		{

		}
		public Schedule(Guid id)
		{
			ID = id;
		}
		public Schedule(Guid id,Guid courseID)
		{
			ID = id;
			CourseID = courseID;
		}
		public Schedule(Guid id, Guid courseID,Guid professorID)
		{
			ID = id;
			CourseID = courseID;
			ProfessorID= professorID;
		}
		public Schedule(Guid id, Guid courseID, Guid professorID,DateTime callender)
		{
			ID = id;
			CourseID = courseID;
			ProfessorID = professorID;
			Callender = callender;
		}
	}
}
