﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_AnnieMorenoSD.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }

        [Display(Name = "Course Information")]
        [Required(ErrorMessage = "Course information is required")]
        [StringLength(100)]
        public string description { get; set; }

        [Display(Name = "Course Price")]
        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal coursePrice { get; set; }
        // the next two properties link the orderDetail to the Order

        
        public int courseID { get; set; }

        public virtual Course Courses { get; set; }
        // the next two properties link the orderDetail to the Product

        
        public int professorID { get; set; }

        public virtual Professor Professors { get; set; }
    }
}
