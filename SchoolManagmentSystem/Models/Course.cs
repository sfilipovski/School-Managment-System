using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagmentSystem.Models
{
    public class Course
    {
        public int courseId { get; set; }
        [Required]
        public string Title { get; set; }
        public string Semester { get; set; }
        [Required]
        public int Code { get; set; }
        [Required]
        [Range(0, 6)]
        public int Credits { get; set; }
        public ICollection<Student> students { get; set; }
        public ICollection<Instructor> instructors { get; set; }
        public Course()
        {
            students = new List<Student>();
            instructors = new List<Instructor>();
        }

    }
}