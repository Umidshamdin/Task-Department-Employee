using DomainLayer.Common;
using Microsoft.EntityFrameworkCore;

namespace RepositoryLayer.Repositories
{
    public class Repository<T> where T : BaseEntity
    {
        private readonly AppDbContext _context;
        private readonly DbSet<T> entities;
        public Repository(AppDbContext context)
        {
            _context = context;
            entities = _context.Set<T>();
        }
        public async Task CreateAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException();

            await entities.AddAsync(entity);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException();

            entity.SoftDelete = true;
            await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await entities.Where(m => m.SoftDelete == false).OrderByDescending(m => m.Id).ToListAsync();
        }

        public async Task<T> GetAsync(int? id)
        {
            T entity = await entities.FirstOrDefaultAsync(m => m.Id == id);

            if (entity is null) throw new NullReferenceException();

            return entity;
        }
        public async Task UpdateAsync(T entity)
        {
            if (entity is null) throw new ArgumentNullException();

            entities.Update(entity);

            await _context.SaveChangesAsync();
        }
    }
}
