using System;

namespace Session_10
{
	public class Schedule
	{
		public Guid ID { get; set; }
		public Guid CourseID { get; set; }
		public Guid ProfessorID { get; set; }
		public DateTime Callender { get; set; }
		public Schedule()
		{
            ID = Guid.NewGuid();
        }
	}
}
