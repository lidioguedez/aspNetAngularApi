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
    public class ProductoRepository : GenericRepository<Producto>, IProductoRepository
    {
        private readonly DbEcommerContext _dbContext;

        public ProductoRepository(DbEcommerContext dbContext) :base (dbContext)
        {
            _dbContext = dbContext;
        }

        public override async Task<IReadOnlyList<Producto>> GetAll()
        {
            return await _dbContext.Productos
                                .Include(m => m.Marca)
                                .Include(c => c.Categoria)
                                .ToListAsync();
        }

        public override async Task<Producto> GetById(int id)
        {
            return await _dbContext.Productos
                            .Include(m => m.Marca)
                            .Include(c => c.Categoria)
                            .FirstOrDefaultAsync(e => e.Id == id); ;
        }
    }
}
