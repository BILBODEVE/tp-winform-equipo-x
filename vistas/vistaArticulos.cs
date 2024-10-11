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
    public partial class vistaArticulos : Form
    {
        private List<Articulo> misArticulos;
        public vistaArticulos()
        {
            InitializeComponent();
        }

        private void vistaArticulos_Load(object sender, EventArgs e)
        {
            InyectarArticulo();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarArticulo vistaAgregar = new agregarArticulo();
            vistaAgregar.ShowDialog();
            InyectarArticulo();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // Devuelve el objeto enlazado de la row
                CargarImagen(articuloActual.Imagen[0]);
            }
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbImagen.Load(url);
            }
            catch (Exception)
            {
                pbImagen.Load("https://img.icons8.com/?size=100&id=1G2BW7-tQJJJ&format=png&color=000000");
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo articuloActual = new Articulo();
            articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            agregarArticulo vistaAgregar = new agregarArticulo(articuloActual);
            vistaAgregar.ShowDialog();
            InyectarArticulo();
        }
        public void InyectarArticulo()
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                misArticulos = articuloNegocio.Listar();
                dgvArticulos.DataSource = misArticulos;
                OcultarColumnas();
                CargarImagen(misArticulos[0].Imagen[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo articuloActual = new Articulo();
            articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            confirmarAccion cuadroDialogo = new confirmarAccion(articuloActual);
            cuadroDialogo.ShowDialog();

        }

        private void btnEliminaciónLógica_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea eliminar el artículo?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.Yes)
            {
                ArticuloNegocio articulo = new ArticuloNegocio();
                Articulo articuloAuxiliar = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                articulo.EliminarLogico(articuloAuxiliar);
                InyectarArticulo();
            }

        }

        private void btnGestionarMarcas_Click(object sender, EventArgs e)
        {
            agregarMarca vistaAgregarMarca = new agregarMarca();
            vistaAgregarMarca.ShowDialog();
        }

        private void btnGestionarCategorias_Click(object sender, EventArgs e)
        {
            agregarCategoria vistaAgregarCategoria = new agregarCategoria();
            vistaAgregarCategoria.ShowDialog();
        }
     
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> articuloFiltrado;
            string nombreBuscado = txtBuscar.Text.ToUpper();

            articuloFiltrado = misArticulos.FindAll(articulo => articulo.Nombre.ToUpper().Contains(nombreBuscado));

            if (articuloFiltrado != null)
            {
                dgvArticulos.DataSource = null;
                dgvArticulos.DataSource = articuloFiltrado;
            }
            OcultarColumnas();
        }
        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
        }

    }
}
