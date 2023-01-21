using System;
namespace Session_10
{
	public class Course
	{
		public Guid ID { get; set; }
		public string Code { get; set; }
		public string Subject { get; set; }
		public Course()
		{
			ID= Guid.NewGuid();

		}		
}
}
