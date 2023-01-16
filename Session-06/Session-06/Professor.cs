using System;

namespace Session-06
{


    public class Professor : Person
    {
        public string Rank { get; set; }
        public Courses[] Courses { get; set; }
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
        public Professor(Guid id, string name, int age, string rank) : base(id, name, age, rank)
        {
            Rank = rank;
        }
        public Professor(Guid id, string name, int age, string rank, Courses courses,) : base(id, name, age, rank, courses)
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
