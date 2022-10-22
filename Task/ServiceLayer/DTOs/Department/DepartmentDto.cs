using DomainLayer.Entities;
using FluentValidation;
using ServiceLayer.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Department
{
    public class DepartmentDto
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Address { get; set; }
        public List<EmployeeDto>? Employees { get; set; }



    }
    public class DepartmentCreateValidator : AbstractValidator<DepartmentDto>
    {
        public DepartmentCreateValidator()
        {
            RuleFor(m => m.Name).NotEmpty().WithMessage("Pleace add name").MinimumLength(4);
            RuleFor(m => m.Address).NotEmpty().WithMessage("Pleace add address");
        }
    }
}
