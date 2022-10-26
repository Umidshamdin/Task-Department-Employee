using AutoMapper;
using DomainLayer.Entities;
using ServiceLayer.DTOs.Department;
using ServiceLayer.DTOs.Employee;

namespace ServiceLayer.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Department, DepartmentDto>().ReverseMap();
            CreateMap<Department, DepartmentEditDto>().ReverseMap();
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Employee, EmployeeCreateDto>().ReverseMap();
            CreateMap<Employee, EmployeeEditDto>().ReverseMap();
        }
    }
}
