using ServiceLayer.DTOs.Employee;

namespace ServiceLayer.DTOs.Department
{
    public class DepartmentEditDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<EmployeeDto>? Employees { get; set; }

        public int? ParentDepartmentId { get; set; } = null;
        public DepartmentDto? ParentDepartment { get; set; }

    }
}
