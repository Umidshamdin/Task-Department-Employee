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
        Task DeleteAsync(int id);

        Task<List<DepartmentDto>> GetAllAsync();
    }
}
