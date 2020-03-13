using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OpenTheDoor.Models;

namespace OpenTheDoor.SSO
{
    internal interface IRepository<TEntity> where TEntity : IEntity
    {
        Task<List<IEntity>> GetAllAsync();
        Task<IEntity> GetById(object id);
        Task<EntityEntry<IEntity>> InsertAsync(TEntity entity);
        void Update(TEntity entity);
        void DeleteAsync(object id);
        void Save();

    }
}
