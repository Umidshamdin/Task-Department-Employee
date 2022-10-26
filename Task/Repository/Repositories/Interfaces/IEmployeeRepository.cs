using DomainLayer.Entities;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<IEnumerable<Employee>> GetEmployeesByDepartmentId(int departmentId);
        Task<List<Employee>> GetAllEmployeesByDepartments();
    }
}
