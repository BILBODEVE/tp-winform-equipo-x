using negocio;
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
            ImagenNegocio imagenNegocio = new ImagenNegocio();
            articuloAuxiliar = new Articulo();

            articuloAuxiliar.Codigo = txtCodigo.Text;
            articuloAuxiliar.Nombre = txtNombre.Text;
            articuloAuxiliar.Descripcion = txtDescripcion.Text;
            articuloAuxiliar.Marca = (Marca)dpdMarca.SelectedItem;
            articuloAuxiliar.Categoria = (Categoria)dpdCategoria.SelectedItem;
            articuloAuxiliar.Imagen.ImagenUrl = txtUrlImagen.Text;
            articuloAuxiliar.Precio = decimal.Parse(txtPrecio.Text);

            nuevoArticulo.Cargar(articuloAuxiliar);
            MessageBox.Show("Operacion exitosa");

            int idArticulo = nuevoArticulo.ObtenerId(articuloAuxiliar.Codigo);
            imagenNegocio.Insertar(idArticulo, articuloAuxiliar.Imagen.ImagenUrl);
        }
        private void agregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                dpdMarca.DataSource = marca.cargar();
                dpdMarca.ValueMember = "Id";
                dpdMarca.DisplayMember = "Descripcion";

                dpdCategoria.DataSource = categoria.cargar();
                dpdCategoria.ValueMember = "Id";
                dpdCategoria.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }
    }
}
