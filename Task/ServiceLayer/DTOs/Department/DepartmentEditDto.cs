using DomainLayer.Entities;
using ServiceLayer.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Department
{
    public class DepartmentEditDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<EmployeeDto>? Employees { get; set; }
    }
}
