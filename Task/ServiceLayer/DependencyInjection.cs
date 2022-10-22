﻿using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using ServiceLayer.DTOs.Department;
using ServiceLayer.DTOs.Employee;
using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer
{
    public static class DependencyInjection
    {
         public static IServiceCollection AddServiceLayer(this IServiceCollection services)
        {

            services.AddScoped<IDepartmentService, DepartmentService>();
            services.AddScoped<IEmployeeService, EmployeeService>();

            services.AddHttpContextAccessor();


            services.AddTransient<IValidator<DepartmentDto>, DepartmentCreateValidator>();
            services.AddTransient<IValidator<EmployeeDto>, EmployeeCreateValidator>();



            return services;
        }
    }
}
