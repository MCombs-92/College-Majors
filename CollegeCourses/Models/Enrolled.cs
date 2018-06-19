﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeCourses.Models { 

    public class Enrolled {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public string Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }

        public Enrolled() { }
    }
}