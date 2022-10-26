using ServiceLayer.DTOs.Department;

namespace ServiceLayer.DTOs.Employee
{
    public class EmployeeEditDto
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int DepartmentId { get; set; }
        public List<DepartmentDto>? Departmens { get; set; }
    }
}
