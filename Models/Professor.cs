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
        [Required(ErrorMessage = "Professor first name is required")]
        [StringLength(20)]
        public string professorFirstName { get; set; }

        [Display(Name = "Professor Last Name")]
        [Required(ErrorMessage = "Professor last name is required")]
        [StringLength(20)]

        public string professorLastName { get; set; }

        [Display(Name = "Professor Email")]
        [RegularExpression(@"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z")]
        [Required(ErrorMessage = "Please enter correct email address")]
        public string professorEmail { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetails { get; set; }
    }
}