using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Department;
using ServiceLayer.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {


            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Department, DepartmentEditDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeEditDto>().ReverseMap();

        }
    }
}
