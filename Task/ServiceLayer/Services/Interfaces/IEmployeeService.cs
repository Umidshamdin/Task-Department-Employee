using DomainLayer.Entities;
using ServiceLayer.DTOs.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task CreateAsync(EmployeeDto employeeDto);

        Task UpdateAsync(int Id, EmployeeEditDto employeeEditDto);
        Task DeleteAsync(int id);
        Task<List<EmployeeDto>> GetAllAsync();
        Task<EmployeeDto> GetAsync(int id);
    }
}
