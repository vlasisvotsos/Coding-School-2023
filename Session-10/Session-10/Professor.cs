﻿using System;

namespace Session_10
{


    public class Professor : Person
    {
        public string Rank { get; set; }
        public List<Course> Courses { get; set; }
        public Professor()
        {
            
        }
        public Professor(List<Course> courses)
        {
            Courses= courses;
        }
        public void SetGrade()
        {

        }
        public void GetName(Guid studentId,Guid courseID,int grade)
        {

        }
    }
}
