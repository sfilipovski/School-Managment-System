using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagmentSystem.Models
{
    public class StudentCourses
    {
        public int studentId { get; set; }
        public int courseId { get; set; }
        public List<Course> Courses { get; set; }
        public List<Student> Students { get; set; }
        public StudentCourses()
        {
            Courses = new List<Course>();
            Students = new List<Student>();
        }
    }
}