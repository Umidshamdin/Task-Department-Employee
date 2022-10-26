using ServiceLayer.DTOs.Employee;

namespace ServiceLayer.Services.Interfaces
{
    public interface IEmployeeService
    {
        Task CreateAsync(EmployeeCreateDto employeeDto);

        Task UpdateAsync(int Id, EmployeeEditDto employeeEditDto);
        Task DeleteAsync(int id);
        Task<List<EmployeeDto>> GetAllAsync();
        Task<EmployeeEditDto> GetAsync(int id);
    }
}
