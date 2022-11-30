using Core.Entities;
using Core.Interfaces;
using Logic.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataAccess
{
    public class UnitOfWork : IUnitOfWork
    {
        private IProductoRepository _productoRepository;
        private IGenericRepository<Marca> _marcaRepository;
        private IGenericRepository<Categoria> _categoriaRepository;
        private DbEcommerContext _dbContext;

        public UnitOfWork(DbEcommerContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IProductoRepository ProductoRepository
        {
            get
            {
                return _productoRepository = _productoRepository ?? new ProductoRepository(_dbContext);
            }
        }

        public IGenericRepository<Marca> MarcaRepository
        {
            get
            {
                return _marcaRepository = _marcaRepository ?? new GenericRepository<Marca>(_dbContext);
            }
        }

        public IGenericRepository<Categoria> CategoriaRepository
        {
            get
            {
                return _categoriaRepository = _categoriaRepository ?? new GenericRepository<Categoria>(_dbContext);
            }
        }


        public async Task saveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
