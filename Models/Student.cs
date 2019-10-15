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
        [Required(ErrorMessage = "Student first name is required")]
        [StringLength(20)]

        public string firstName { get; set; }

        [Display(Name = "Student Last Name")]
        [Required(ErrorMessage = "Student first name is required")]
        [StringLength(20)]

        public string lastName { get; set; }

        [Display(Name = "Student Email")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
        [Required(ErrorMessage = "Please enter correct email address")]

        public string email { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}