using System;

namespace Session06
{


    public class Professor : Person
    {
        public string Rank { get; set; }
        public Course[] Courses { get; set; }
        public Professor()
        {
        }   
        public Professor(Guid id) : base(id)
        {
        }
        public Professor(Guid id, string name) : base(id, name)
        {
        }
        public Professor(Guid id, string name, int age) : base(id, name, age)
        {
        }
        public Professor(Guid id, string name, int age, string rank) : base (id, name, age)
        {
            Rank = rank;
        }
        public Professor(Guid id, string name, int age, string rank, Course[] courses,) : base (id, name, age)
        {
            Rank = rank;
            Courses = courses;
        }
        public void Teach(Course course, DateTime date)
        {

        }
        public void SetGrade()
        {

        }
        public void GetName()
        {

        }
    }
}
