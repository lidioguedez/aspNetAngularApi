using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ProductosDTO
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public string MarcaNombre { get; set; }
        public string CategoriaNombre { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }
    }
}
