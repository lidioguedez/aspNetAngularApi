using Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Logic.Data.Seeders
{
    public static partial class ProductoDataSeeder
    {
        public static void ProductoDataSeed(EntityTypeBuilder<Producto> builder)
        {
           builder.HasData(
                new { Id = 1, Nombre = "Producto Generico 1", Descripcion = "Descripcion Generica 1", Stock = 5, MarcaId = 1, CategoriaId = 1, precio = 152.45, imagen = "https://localhost/imagesn/imagen1.jpg" },
                new { Id = 2, Nombre = "Producto Generico 2", Descripcion = "Descripcion Generica 2", Stock = 5, MarcaId = 2, CategoriaId = 2, precio = 60.30, imagen = "https://localhost/imagesn/imagen2.jpg" },
                new { Id = 3, Nombre = "Producto Generico 3", Descripcion = "Descripcion Generica 3", Stock = 5, MarcaId = 3, CategoriaId = 3, precio = 200, imagen = "https://localhost/imagesn/imagen3.jpg" }
                );

        }
    }
}
