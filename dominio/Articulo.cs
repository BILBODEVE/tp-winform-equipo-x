﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Marca {  get; set; }
        public string Categoria { get; set; }
        public string URLImage { get; set; }
        public decimal Precio { get; set; }
    }
}
