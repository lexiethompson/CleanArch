﻿using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Repository;
using CleanArchApplication.Interfaces;
using CleanArchApplication.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ICourseService, CourseService>();

            //Infra.Data Layer
            services.AddScoped<ICourseRepository, CourseRepository>();


        }
    }
}
