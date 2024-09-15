﻿using negocio;
using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas
{
    public partial class agregarArticulo : Form
    {
        private Articulo articuloAuxiliar;
        public agregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevoArticulo = new ArticuloNegocio();
            articuloAuxiliar = new Articulo();
            articuloAuxiliar.Codigo = txtCodigo.Text;
            articuloAuxiliar.Nombre = txtNombre.Text;
            articuloAuxiliar.Descripcion = txtDescripcion.Text;
            articuloAuxiliar.Marca = txtMarca.Text;
            articuloAuxiliar.Categoria = txtCategoria.Text;
            articuloAuxiliar.URLImage = txtUrlImagen.Text;
            articuloAuxiliar.Precio = decimal.Parse(txtPrecio.Text);
            //nuevoArticulo.Cargar(articuloAuxiliar);
            MessageBox.Show(articuloAuxiliar.Codigo + "\n" + articuloAuxiliar.Nombre + "\n" + articuloAuxiliar.Descripcion + "\n" + articuloAuxiliar.Marca + "\n" + articuloAuxiliar.Categoria + "\n" + articuloAuxiliar.Precio + "\n" + articuloAuxiliar.URLImage);
        }
    }
}
