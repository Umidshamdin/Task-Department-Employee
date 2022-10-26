using DomainLayer.Common;

namespace DomainLayer.Entities
{
    public class Employee : BaseEntity
    {
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
