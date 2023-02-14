using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SchoolManagmentSystem.Models
{
    public class InstructorCourses
    {
        public int instructorId { get; set; }
        public int courseId { get; set; }
        public List<Course> courses { get; set; }
        public List<Instructor> instructors { get; set; }
        public InstructorCourses()
        {
            courses = new List<Course>();
            instructors = new List<Instructor>();
        }

    }
}