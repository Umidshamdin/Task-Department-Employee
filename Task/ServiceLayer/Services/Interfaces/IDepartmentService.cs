using DomainLayer.Entities;
using ServiceLayer.DTOs.Department;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services.Interfaces
{
    public interface IDepartmentService
    {
        Task CreateAsync(DepartmentDto departmentDto);
        Task UpdateAsync(int Id, DepartmentEditDto departmentEditDto);
        Task DeleteAsync(int id);
        Task<List<DepartmentDto>> GetAllAsync();
        Task<DepartmentEditDto> GetByIdAsync(int id);
        Task<DepartmentDto> Detail(int id);
    }
}
