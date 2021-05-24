using CleanArchApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchApplication.Interfaces
{
    interface ICourseService
    {
        CourseViewModel GetCourses(); 
    }
}
