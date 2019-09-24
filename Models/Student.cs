using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MIS4200_AnnieMorenoSD.Models
{
    public class Student
    {
        public int studentID { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public ICollection<Course> Courses { get; set; }
    }
}