using System;

namespace Session-06
{

	public class Person
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public Person()
		{

		}
		public Person(Guid id)
		{
			Id = id;
		}
		public Person(Guid id, string name)
		{
			Id = id;
			Name = name;
		}
		public Person(Guid id, string name, int age)
		{
			Id = id;
			Name = name;
			Age = age;
		}
		public void GetName()
		{

		}
		public void SetName(string name)
		{
			Name = name;
		}
	}
}
