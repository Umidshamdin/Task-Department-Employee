using FluentValidation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.DTOs.Employee
{
    public class EmployeeCreateDto
    {
        [Required]
        public string? FullName { get; set; }
        [Required]
        [Range(0, 100)]
        public int Age { get; set; }
        [Required]
        [Phone]
        public string? PhoneNumber { get; set; }
        [Required]
        [EmailAddress]
        public string? Email { get; set; }
        public int DepartmentId { get; set; }
    }

    public class EmployeeCreateValidator : AbstractValidator<EmployeeCreateDto>
    {
        public EmployeeCreateValidator()
        {
            RuleFor(m => m.FullName).NotEmpty().WithMessage("Pleace add fullname").MinimumLength(4);
            RuleFor(m => m.Age).NotEmpty().WithMessage("Pleace add age");
            RuleFor(m => m.PhoneNumber).NotEmpty().WithMessage("Pleace add phonenumber");
            RuleFor(m => m.Email).NotEmpty().WithMessage("Pleace add email");
            RuleFor(m => m.DepartmentId).NotEmpty().WithMessage("Pleace add address");
        }
    }
}
