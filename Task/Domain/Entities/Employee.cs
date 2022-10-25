using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Employee:BaseEntity
    {
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }
    }
}
