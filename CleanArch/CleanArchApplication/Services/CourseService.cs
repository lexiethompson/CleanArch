using CleanArch.Domain.Interfaces;
using CleanArchApplication.Interfaces;
using CleanArchApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchApplication.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public CourseViewModel GetCourses()
        {
            return new CourseViewModel()
            {
                Courses = _courseRepository.GetCourses()
            };
        }
    }
}

