using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_AnnieMorenoSD.Models
{
    public class Course
    {
        public int courseID { get; set; }

        [Display (Name = "Course description")]
        [Required(ErrorMessage ="Course description is required")]
        [StringLength(100)]
        public string description { get; set; }

        [Display(Name = "Course Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:d}", ApplyFormatInEditMode = true)]
        public DateTime courseDate { get; set; }
        // add any other fields as appropriate
        //Order is on the "one" side of a one-to-many relationship with OrderDetail
        //and we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetails { get; set; }
        //Order is on the Many side of the one-to-many relation between Customer
        //and Order and we represent that relationship like this
        public int studentID { get; set; }
        public virtual Student Students { get; set; }
    }
}