using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Department : BaseEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Employee>? Employees { get; set; }
        public Department? ParentDepartment { get; set; }
        public List<Department>? ChildDepartment { get; set; }

    }
}
