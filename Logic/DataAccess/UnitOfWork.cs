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

        public async Task saveChanges()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
