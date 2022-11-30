using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces.Services
{
    public interface IGenericServices<T> where T : EntityBase
    {
        Task<T> GetById(int id);
        Task<IReadOnlyList<T>> GetAll();
        Task<T> GetByIdWithSpec(string? name, int? marca, int? categoria);
        Task<IReadOnlyList<T>> GetAllWithSpec(string? name, int? marca, int? categoria);
        Task Remove(T entity);
        Task Add(T entity);
        Task Update(T entity);
        Task SaveChanges();

    }
}
