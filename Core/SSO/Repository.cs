using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Core.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OpenTheDoor.SSO;

namespace Core.SSO
{
    public class Repository<T> : IRepository<T>  where T : class
    {
        private SSOContext _context;
        private   DbSet<T> table = null;
        private string connectionString;

        public Repository(SSOContext ssoContext)
        {
            _context = ssoContext;
            table = _context.Set<T>();
        }

        public async void DeleteAsync(object id)
        {
            T existing = await table.FindAsync(id);
            table.Remove(existing);
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await table.ToListAsync();
        }

        public async Task<T> GetById(object id)
        {
            return await table.FindAsync(id);
        }

        public async void InsertAsync(T entity)
        {
             await table.AddAsync(entity);
        }

        public async void Save()
        {
            await _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            table.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}