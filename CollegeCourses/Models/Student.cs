using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CollegeCourses.Controllers;

namespace CollegeCourses.Models {

    public class Student {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? MajorId { get; set; }
        public int SAT { get; set; }

        public virtual Major Major { get; set; }

        public Student() { }
    }
}