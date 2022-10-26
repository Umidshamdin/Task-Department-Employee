using DomainLayer.Entities;

namespace RepositoryLayer.Repositories.Interfaces
{
    public interface IDepartmentRepository : IRepository<Department>
    {
        Task<Department> GetDepartmentDetail(int id);
        Task<Department> GetDepartmentById(int id);
    }
}
