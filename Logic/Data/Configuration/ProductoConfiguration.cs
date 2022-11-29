﻿using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data.Configuration
{
    public class ProductoConfiguration : IEntityTypeConfiguration<Producto>
    {
        public void Configure(EntityTypeBuilder<Producto> builder)
        {
            builder.Property(p => p.Nombre).IsRequired().HasMaxLength(250);
            builder.Property(p => p.Descripcion).IsRequired().HasMaxLength(500);
            builder.Property(p => p.imagen).HasMaxLength(1000);
            builder.Property(p => p.precio).HasColumnType("decimal()18,2");
            builder.HasOne(m => m.Marca).WithMany().HasForeignKey(k => k.MarcaId);
            builder.HasOne(c => c.Categoria).WithMany().HasForeignKey(k => k.CategoriaId);
        }
    }
}