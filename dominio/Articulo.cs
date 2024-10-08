﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        public Articulo()
        {
            Marca = new Marca();
            Categoria = new Categoria();
            Imagen = new List<string>();
        }
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca{ get; set; }
        public Categoria Categoria { get; set; }
        public List<string> Imagen { get; set; }
        public decimal Precio { get; set; }
    }
}
