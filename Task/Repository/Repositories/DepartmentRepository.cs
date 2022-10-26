using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using RepositoryLayer.Repositories.Interfaces;

namespace RepositoryLayer.Repositories
{
    public class DepartmentRepository : Repository<Department>, IDepartmentRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Department> entities;
        public DepartmentRepository(AppDbContext context) : base(context)
        {
            _context = context;
            entities = context.Set<Department>();
        }

        public async Task<Department> GetDepartmentById(int id)
        {
            return await entities.Where(m => m.Id == id).Include(m => m.Employees.Where(x => x.SoftDelete == false)).FirstOrDefaultAsync();
        }

        public async Task<Department> GetDepartmentDetail(int id)
        {
            var detail = await entities
                                .Where(e => e.Id == id)
                                .Include(x => x.ParentDepartment)
                                .Include(m => m.Employees.Where(x => x.SoftDelete == false))
                                .FirstOrDefaultAsync();
            return detail;
        }
    }
}
