using CollegeCourses.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CollegeCourses.ViewModels {

    public class ViewMajors {
       public  IEnumerable<Major> majors { get; set; }

        public ViewMajors() { }
    }
}