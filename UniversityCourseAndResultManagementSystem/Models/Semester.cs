﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversityCourseAndResultManagementSystem.Models
{
    public class Semester
    {
        [Key]
        [Display(Name = "Semester")]
        public int SemesterId { get; set; }

        [Display(Name = "Semester Name")]
        public string SemesterName { get; set; }

        public virtual ICollection<Course> Courses { get; set; }
    }
}
