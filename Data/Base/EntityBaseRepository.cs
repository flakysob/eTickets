using eTickets.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace eTickets.Data.Base
{
    public class EntityBaseRepository<T> : IEntityBaseRepository<T> where T : class, IEntityBase, new()
    {
        private readonly AppDbContext _context;

        public EntityBaseRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(T entity) 
            => await _context.Set<T>().AddAsync(entity);
        public async Task<IEnumerable<T>> GetAllAsync() 
            => await _context.Set<T>().ToListAsync();
        public async Task<T> GetByIdAsync(int id)
            => await _context.Set<T>().FirstOrDefaultAsync(x => x.Id == id);


        public Task DeleteAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<T> UpdateAsync(int id, T entity)
        {
            throw new System.NotImplementedException();
        }
    }
}
