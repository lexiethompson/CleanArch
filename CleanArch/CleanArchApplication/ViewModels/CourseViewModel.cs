using CleanArch.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchApplication.ViewModels
{
    class CourseViewModel
    {
        public IEnumerable<Course> Courses { get; set; }
    }
}
