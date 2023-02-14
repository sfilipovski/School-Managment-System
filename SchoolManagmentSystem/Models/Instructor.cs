using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SchoolManagmentSystem.Models
{
    public class Instructor
    {
        public int instructorId { get; set; }
        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Date of hire")]
        public DateTime HireDate { get; set; }
        [Required]
        [RegularExpression(@"\w+ \d+", ErrorMessage ="Must be of format 'Room/Office ###' ")]
        public string Office { get; set; }
        public ICollection<Course> courses { get; set; }
        public Instructor()
        {
            courses = new List<Course>();
        }
    }
}