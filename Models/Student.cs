using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_AnnieMorenoSD.Models
{
    public class Student
    {
        public int studentID { get; set; }

        [Display(Name = "Student First Name")]
       
        public string firstName { get; set; }

        [Display(Name = "Student Last Name")]
        
        public string lastName { get; set; }

        [Display(Name = "Student Email")]
        
        public string email { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}