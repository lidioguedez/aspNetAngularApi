using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.DataAccess
{
    public class DbEcommerContext : DbContext
    {
        public DbEcommerContext(DbContextOptions options) : base (options)
        {

        }

        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Marca> Marca { get; set; }
    }
}
