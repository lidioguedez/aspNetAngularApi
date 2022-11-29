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
        public int Marca { get; set; }

        [Column(TypeName="decimal(18,4)")]
        public decimal precio { get; set; }
        public string imagen { get; set; } 
    }
}
