using DomainLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using RepositoryLayer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public async Task<Department> GetDepartmentDetail(int id)
        {
            var detail = await entities
                                .Where(e => e.Id == id)
                                .Include(m => m.Employees.Where(x => x.SoftDelete == false))
                                .FirstOrDefaultAsync();
            return detail;                                  
        }
    }
}
