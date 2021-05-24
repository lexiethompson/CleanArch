using CleanArchApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchApplication.Interfaces
{
    public interface ICourseService
    {
        CourseViewModel GetCourses(); 
    }
}
