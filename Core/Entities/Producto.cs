using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Producto : EntityBase
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int MarcaId { get; set; }
        public Marca Marca { get; set; }
        public int CategoriaId { get; set; }
        public Categoria Categoria { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; } 
    }
}
