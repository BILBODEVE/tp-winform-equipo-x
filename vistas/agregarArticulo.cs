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
        private Articulo articulo = null;
        
        public agregarArticulo()
        {
            InitializeComponent();
        }
        public agregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevoArticulo = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            if(articulo == null)
                articulo = new Articulo();

            articulo.Codigo = txtCodigo.Text;
            articulo.Nombre = txtNombre.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.Marca = (Marca)dpdMarca.SelectedItem;
            articulo.Categoria = (Categoria)dpdCategoria.SelectedItem;
            articulo.Imagen.ImagenUrl = txtUrlImagen.Text;
            articulo.Precio = decimal.Parse(txtPrecio.Text);

            if(articulo.Id != 0)
                nuevoArticulo.Modificar(articulo);
            else
                nuevoArticulo.Cargar(articulo);

            MessageBox.Show("Operacion exitosa");
            LimpiarCampos();
        }
        private void agregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                dpdMarca.DataSource = marca.Cargar();
                dpdMarca.ValueMember = "Id";
                dpdMarca.DisplayMember = "Descripcion";

                dpdCategoria.DataSource = categoria.Cargar();
                dpdCategoria.ValueMember = "Id";
                dpdCategoria.DisplayMember = "Descripcion";

                if (this.articulo != null)
                {
                    txtCodigo.Text = this.articulo.Codigo;
                    txtNombre.Text = this.articulo.Nombre;
                    txtDescripcion.Text = this.articulo.Descripcion;
                    dpdMarca.SelectedValue = this.articulo.Marca.Id;
                    dpdCategoria.SelectedValue = this.articulo.Categoria.Id;
                    txtUrlImagen.Text = this.articulo.Imagen.ImagenUrl;
                    txtPrecio.Text = this.articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Text = null;
            txtNombre.Text = null;
            txtDescripcion.Text = null;
            txtUrlImagen.Text = null;
            txtPrecio.Text = null;
        }
    }
}
