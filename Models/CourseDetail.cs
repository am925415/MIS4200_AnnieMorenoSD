using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_AnnieMorenoSD.Models
{
    public class CourseDetail
    {
        public int courseDetailID { get; set; }
        public string courseDetails { get; set; }
        public decimal coursePrice { get; set; }
        // the next two properties link the orderDetail to the Order
        public int courseID { get; set; }

        public virtual Course Courses { get; set; }
        // the next two properties link the orderDetail to the Product
        public int professorID { get; set; }

        public virtual Professor Professors { get; set; }
    }
}
