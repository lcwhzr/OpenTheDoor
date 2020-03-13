using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using OpenTheDoor.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace OpenTheDoor.SSO
{
    public class Repository<TEntity> : IRepository<TEntity>
        where TEntity : class, IEntity
    {
        private SSOContext _context = null;
        private DbSet<IEntity> table = null;

        public Repository()
        {
            _context = new SSOContext();
            table = _context.Set<IEntity>();
        }



        public async void DeleteAsync(object id)
        {
            IEntity existing = await table.FindAsync(id);
            table.Remove(existing);
        }

        public async Task<List<IEntity>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<IEntity> GetById(object id)
        {
            return await table.FindAsync(id);
        }

        public async Task<EntityEntry<IEntity>> InsertAsync(TEntity entity)
        {
            return await table.AddAsync(entity);
        }

        public async void Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }

    }
}