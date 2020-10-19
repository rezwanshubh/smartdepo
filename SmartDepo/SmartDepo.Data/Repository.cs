using Microsoft.EntityFrameworkCore;
using SmartDepo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartDepo.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        private SmartDepoContext _context = null;
        private DbSet<TEntity> entities = null;

        public Repository(SmartDepoContext context)
        {
            this._context = context;
            entities = context.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> GetAll()
        {
            return await entities.ToListAsync();
        }

        public async Task<TEntity> GetById(Guid id)
        {
            return await entities.SingleOrDefaultAsync(s => s.Id == id);
        }

        public async Task<TEntity> Insert(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            entity.CreatedAt = DateTime.Now;
            entities.Add(entity);

            await _context.SaveChangesAsync();

            return entity;
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            if (entity == null) throw new ArgumentNullException("entity");

            _context.Update(entity);
            await _context.SaveChangesAsync();

            return entity;
        }
        public void Delete(Guid id)
        {
            if (id == null) throw new ArgumentNullException("entity");

            TEntity entity = entities.SingleOrDefault(s => s.Id == id);

            _context.Remove(entity);
            _context.SaveChanges();
        }
    }
}
