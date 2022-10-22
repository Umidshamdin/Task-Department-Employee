using DomainLayer.Entities;
using ServiceLayer.DTOs.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public int DepartmentId { get; set; }
        public DepartmentDto Department { get; set; }

        public List<DepartmentDto>? Departmens { get; set; }


    }
}
