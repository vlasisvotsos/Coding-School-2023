using System;

public class Student : Person
{
	public int RegistrationNumber { get; set; }
	public Course Course[] { get; set; }
	public Student()
	{
	}
	public Student(Guid id) : base (id)
	{
	}
	public Student(Guid id,string name) : base(id,name)
    {
	}
	public Student(Guid id, string name, int age) : base(id, name, age)
    {
	}
	public Student(Guid id, string name, int age,int registrationNumber) : base(id, name, age)
    {
	RegistrationNumber = registrationNumber;
	}
	public Student(Guid id, string name, int age, int registrationNumber,Course course[]) : base(id, name, age)
    {
    RegistrationNumber = registrationNumber;
	Course[]= course[];

	}
	public void Attend(Corse corse, DateTime date)
	{

	}
	public void WriteExam(Corse corse, DateTime date)
	{

	}
}
