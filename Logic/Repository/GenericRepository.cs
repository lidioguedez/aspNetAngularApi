using Core.Entities;
using Core.Interfaces;
using Logic.DataAccess;
using Logic.Services;
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


        public virtual async Task Add(T entity)
        {
            await _db.AddAsync(entity);
        }

        public virtual async Task<IReadOnlyList<T>> GetAll()
        {
            return await _db.ToListAsync();
        }

        public virtual async Task<IReadOnlyList<T>> GetAllWithSpec(ISpecification<T> spec)
        {
            return await this.AppliSpecification(spec).ToListAsync();
        }

        public virtual async Task<T> GetById(int id)
        {
            return await _db.FirstOrDefaultAsync(e => e.Id == id); ;
        }

        public virtual async Task<T> GetByIdWithSpec(ISpecification<T> spec)
        {
            return await AppliSpecification(spec).FirstOrDefaultAsync();
        }

        public virtual async Task Remove(T entity)
        {
             _db.Remove(entity); ;
        }

        public virtual async Task Update(T entity)
        {
            _db.Update(entity);
        }

        private IQueryable<T> AppliSpecification(ISpecification<T> spec)
        {
            return SpecificationEvaluator<T>.GetQuery(_db.AsQueryable(), spec);
        }

    }
}
