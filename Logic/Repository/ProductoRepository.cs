using Core.Entities;
using Core.Interfaces;
using Logic.DataAccess;
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


    }
}
