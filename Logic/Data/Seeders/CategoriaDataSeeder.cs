using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data.Seeders
{
    public static partial class CategoriaDataSeeder
    {
        public static void CategoriaDataSeed(EntityTypeBuilder<Categoria> builder)
        {
            builder.HasData(
                new { Id = 1, Nombre = "Categoria Uno" },
                new { Id = 2, Nombre = "Categoria Dos" },
                new { Id = 3, Nombre = "Categoria Tres" }
                );
        }
    }
}
