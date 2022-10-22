using DomainLayer.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Entities
{
    public class Department:BaseEntity
    {
        public string? Name { get; set; }
        public string? Address { get; set; }
        public List<Employee>? Employees { get; set; }
    }
}
