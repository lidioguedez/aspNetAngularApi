using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Data.Seeders
{
    public static partial class MarcaDataSeeder
    {
        public static void MarcaDataSeed(EntityTypeBuilder<Marca> builder)
        {
            builder.HasData(
                new { Id = 1, Nombre = "Marca Generica 1" },
                new { Id = 2, Nombre = "Marca Generica 2" },
                new { Id = 3, Nombre = "Marca Generica 3" }
                );
        }
    }
}
