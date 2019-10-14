using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MIS4200_AnnieMorenoSD.Models
{
    public class Professor
    {
        public int professorID { get; set; }

        [Display(Name = "Professor First Name")]
        public string professorFirstName { get; set; }

            [Display(Name = "Professor Last Name")]

           public string professorLastName { get; set; }

        [Display(Name = "Professor Email")]
        public string professorEmail { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetails { get; set; }
    }
}