using Core.Entities;
using Core.Interfaces;
using Core.Interfaces.Services;
using Logic.DataAccess;
using Logic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Services
{
    public class ProductoServices : IGenericServices<Producto>, IProductoService
    {
        private IUnitOfWork _uow;
        public ProductoServices(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task Add(Producto entity)
        {
            await _uow.ProductoRepository.Add(entity);
        }

        public async Task<IReadOnlyList<Producto>> GetAll()
        {
           return await _uow.ProductoRepository.GetAll();
        }

        public async Task<Producto> GetById(int id)
        {
            return await _uow.ProductoRepository.GetById(id);
        }

        public async Task Remove(Producto entity)
        {
            await _uow.ProductoRepository.Remove(entity);
        }

        public async Task Update(Producto entity)
        {
            await _uow.ProductoRepository.Update(entity);
        }

        public async Task SaveChanges()
        {
            await _uow.saveChanges();
        }
    }
}
