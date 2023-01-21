using System;

namespace Session06
{

	public class Person
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public Person()
		{
			ID= Guid.NewGuid();
		}
		public void GetName()
		{

		}
		public void SetName(string name)
		{
		
		}
	}
}
