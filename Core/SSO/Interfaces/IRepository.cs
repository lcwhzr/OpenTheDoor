using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using OpenTheDoor.Core.Models;

namespace OpenTheDoor.Core.SSO
{
    internal interface IRepository<T> 
    {
        Task<List<T>> GetAllAsync();
        Task<T> GetById(object id);
        void InsertAsync(T obj);
        void Update(T entity);
        void DeleteAsync(object id);
        void Save();
    }
}
