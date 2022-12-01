﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class ProductosDTO
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Stock { get; set; }
        public int MarcaID { get; set; }
        public string MarcaNombre { get; set; }
        public int CategoriaID { get; set; }
        public string CategoriaNombre { get; set; }
        public decimal precio { get; set; }
        public string imagen { get; set; }
    }
}
