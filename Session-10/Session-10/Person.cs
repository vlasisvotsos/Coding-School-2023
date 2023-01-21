﻿using System;

namespace Session06
{

	public class Person
	{
		public Guid ID { get; set; }
		public string Name { get; set; }
		public int Age { get; set; }
		public Person()
		{

		}
		public Person(Guid id)
		{
			ID = id;
		}
		public Person(Guid id, string name)
		{
			ID = id;
			Name = name;
		}
		public Person(Guid id, string name, int age)
		{
			ID = id;
			Name = name;
			Age = age;
		}
		public void GetName()
		{

		}
		public void SetName(string name)
		{
		
		}
	}
}
