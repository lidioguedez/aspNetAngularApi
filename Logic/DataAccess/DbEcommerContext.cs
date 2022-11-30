﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;


namespace Logic.DataAccess
{
    public class DbEcommerContext : DbContext
    {
        public DbEcommerContext(DbContextOptions<DbEcommerContext> options) : base (options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
 
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        }

        public DbSet<Producto> Productos { get; set; }
        public DbSet<Categoria> Categgoria { get; set; }
        public DbSet<Marca> Marca { get; set; }

    }
}
