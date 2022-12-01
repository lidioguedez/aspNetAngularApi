using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Specifications
{
    public class ProductoSpecifications : BaseSpecification<Producto>
    {
        public ProductoSpecifications(string? name, int? marca, int? categoria)
            : base ()
        {
            AddInclude(p => p.Marca);
            AddInclude(p => p.Categoria);
        }

        public ProductoSpecifications(int id)
          : base(x => (x.Id == id))
        {
            AddInclude(p => p.Marca);
            AddInclude(p => p.Categoria);
        }
    }
}
