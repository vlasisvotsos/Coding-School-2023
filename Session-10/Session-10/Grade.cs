using System;

namespace Session06
{

	public class Grade
	{
		public Guid ID { get; set; }
		public Guid StudentID { get; set; }	
		public Guid CourseID { get; set; }
		public int Grades { get; set; }
		public Grade()
		{
			ID= Guid.NewGuid();
		}		
}
}
