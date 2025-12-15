using System.ComponentModel.DataAnnotations;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD.Models
{
    [Table("Students")]
    public class Students
    {
        [Key]
        [Display(Name = "Student ID")]
        public int StudentId { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string? Name { get; set; }
       
        [Display(Name = "Email")]
        public string? Email { get; set; }
       
        [Display(Name = "Course")]
        public string? Course { get; set; }
       
        [Display(Name = "Enrollment Date")] 
        public DateTime? EnrollmentDate { get; set; }
    }
}