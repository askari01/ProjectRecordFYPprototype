using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectRecord.Models
{
    public class Student
    {
        [Display(Name = "Student")]
        public int StudentID { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Enter Student Name")]
        [Display(Name = "Student Name")]
        public string Name { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Enter Registration Number (complete)")]
        [Display(Name = "Registration Number")]
        public string RegistrationNo { get; set; }

        [Required(ErrorMessage = "Enter Batch Number")]
        public int Batch { get; set; }

        public virtual List<Project> Project { get; set; }
    }
}