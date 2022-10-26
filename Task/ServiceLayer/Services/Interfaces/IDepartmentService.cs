using ServiceLayer.DTOs.Department;

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
