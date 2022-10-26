using ServiceLayer.DTOs.Department;
using System.ComponentModel.DataAnnotations;

namespace ServiceLayer.DTOs.Employee
{
    public class EmployeeDto
    {
        public int Id { get; set; }

        [Required]
        public string? FullName { get; set; }
        [Required]
        public int Age { get; set; }

        [Required]
        public string? PhoneNumber { get; set; }

        [Required]
        public string? Email { get; set; }

        public int DepartmentId { get; set; }

        public DepartmentDto? Department { get; set; }

        public List<DepartmentDto>? Departmens { get; set; }
    }
}
