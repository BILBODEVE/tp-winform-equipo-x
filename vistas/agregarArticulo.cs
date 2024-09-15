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
        private List<Marca> marcas;
        private List<Categoria> categorias;
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
            articuloAuxiliar.URLImage = txtUrlImagen.Text;
            articuloAuxiliar.Imagen.ImagenUrl = txtUrlImagen.Text;
            articuloAuxiliar.Precio = decimal.Parse(txtPrecio.Text);
            //nuevoArticulo.Cargar(articuloAuxiliar);
            MessageBox.Show(articuloAuxiliar.Codigo + "\n" + articuloAuxiliar.Nombre + "\n" + articuloAuxiliar.Descripcion + "\n" + articuloAuxiliar.Marca + "\n" + articuloAuxiliar.Categoria + "\n" + articuloAuxiliar.Precio + "\n" + articuloAuxiliar.URLImage);
        }

            nuevoArticulo.Cargar(articuloAuxiliar);
            MessageBox.Show("Operacion exitosa");

            int idArticulo = nuevoArticulo.ObtenerId(articuloAuxiliar.Codigo);
            imagenNegocio.Insertar(idArticulo, articuloAuxiliar.Imagen.ImagenUrl);
        }
        private void agregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            this.marcas = marca.cargar();
            foreach(Marca item in this.marcas)
            {
                dpdMarca.Items.Add(item.Descripcion);
            }

            CategoriaNegocio categoria = new CategoriaNegocio();
            this.categorias = categoria.cargar();

            foreach(Categoria tipo in this.categorias)
            {
                dpdCategoria.Items.Add(tipo.Descripcion);
            }

        }
    }
}
