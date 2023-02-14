using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagmentSystem.Models
{
    public class Student
    {
        public int studentId { get; set; }
        [Required]
        [Display(Name ="First Name")]
        public string FirstName { get; set; }
        [Display(Name = "Student Id")]
        public int studentCode { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }
        public virtual ICollection<Course> courses { get; set; }
        public Student()
        {
            courses = new List<Course>();
        }

    }
}