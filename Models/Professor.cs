using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_AnnieMorenoSD.Models
{
    public class Professor
    {
        public int professorID { get; set; }
        public string professorFirstName { get; set; }
        public string professorLastName { get; set; }
        public string professorEmail { get; set; }
        // add any other fields as appropriate
        //Product is on the "one" side of a one-to-many relationship with OrderDetail
        //we indicate that with an ICollection
        public ICollection<CourseDetail> CourseDetails { get; set; }
    }
}