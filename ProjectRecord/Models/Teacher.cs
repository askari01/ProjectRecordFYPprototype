using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProjectRecord.Models
{
    public class Teacher
    {
        [Display(Name ="Teacher")]
        public int TeacherID { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "Enter Teacher Name")]
        [Display(Name = "Teacher Name")]
        public string Name { get; set; }

        //[Display(Name = "First Name")]
        [Required]
        [StringLength(100, ErrorMessage = "Enter Designation")]
        public string Designation { get; set; }

        [Display(Name = "Project Evulation Committee")]
        public Boolean PREC { get; set; }

        [Display(Name = "Evaluation Committee")]
        public Boolean EC { get; set; }

        [Display(Name = "Project Coordinator")]
        public Boolean ProjCoordinator { get; set; }

        public virtual List<Project> Project { get; set; }

    }
}