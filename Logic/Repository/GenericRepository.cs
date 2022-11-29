using Core.Entities;
using Core.Interfaces;
using Logic.DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : EntityBase
    {
        private DbSet<T> _db;

        public GenericRepository(DbEcommerContext dbContext)
        {
            _db = dbContext.Set<T>();
        }


        public async Task Add(T entity)
        {
            await _db.AddAsync(entity);
        }

        public async Task<IReadOnlyList<T>> GetAll()
        {
            return await _db.ToListAsync();
        }

        public async Task<T> GetById(int id)
        {
            return await _db.FirstOrDefaultAsync(e => e.Id == id); ;
        }

        public async Task Remove(T entity)
        {
             _db.Remove(entity); ;
        }

        public async Task Update(T entity)
        {
            _db.Update(entity);
        }

    }
}
