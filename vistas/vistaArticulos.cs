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
using System.Text.RegularExpressions;
using System.Configuration;

namespace vistas
{
    public partial class vistaArticulos : Form
    {
        private List<Articulo> misArticulos;
        private HelperVistas helperVistas;
        private bool vistaInicializada = false;
        static int indexImagen = 0;
        public vistaArticulos()
        {
            InitializeComponent();
            helperVistas = new HelperVistas();
        }
        private void vistaArticulos_Load(object sender, EventArgs e)
        {
            InyectarArticulo();
            CargarComboBox();
            OcultarVistaDetalles();
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregarArticulo vistaAgregar = new agregarArticulo();
            vistaAgregar.ShowDialog();
            InyectarArticulo();
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // Devuelve el objeto enlazado de la row
                helperVistas.CargarImagenDesdeArticulo(pbImagen, articuloActual);
            }
            OcultarVistaDetalles();
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
                misArticulos = articuloNegocio.Listar(ConfigurationManager.AppSettings["queryListar"]);
                dgvArticulos.DataSource = misArticulos;
                OcultarColumnas();
                helperVistas.CargarImagenDesdeArticulo(pbImagen,misArticulos[0]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void InyectarArticulo(string query)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            try
            {
                misArticulos = articuloNegocio.Listar(query);
                dgvArticulos.DataSource = misArticulos;
                OcultarColumnas();
                helperVistas.CargarImagenDesdeArticulo(pbImagen, misArticulos[0]);
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
            List<Articulo> articulosBuscados;
            string nombreBuscado = txtBuscar.Text.ToUpper();
            articulosBuscados = FiltrarPorNombre(nombreBuscado);
            CargarDataGridView(articulosBuscados);
        }
        private void cbFiltroMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vistaInicializada)
            {
                List<Articulo> filtradosPorMarca;
                string marcaBuscada = cbFiltroMarca.SelectedItem.ToString();

                if (cbFiltroCategoria.SelectedItem.ToString() != "Todos")
                {
                    string categoriaBuscada = cbFiltroCategoria.SelectedItem.ToString();
                    if (marcaBuscada != "Todos")
                        filtradosPorMarca = FiltrarCriterioDoble(marcaBuscada, categoriaBuscada);
                    else
                        filtradosPorMarca = FiltrarPorCategoria(categoriaBuscada);
                }
                else
                {
                    filtradosPorMarca = FiltrarPorMarca(marcaBuscada);
                }
                CargarDataGridView(filtradosPorMarca);
            }
        }
        private void cbFiltroCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (vistaInicializada)
            {
                List<Articulo> filtradosPorCategoria;
                string categoriaBuscada = cbFiltroCategoria.SelectedItem.ToString();

                if (cbFiltroMarca.SelectedItem.ToString() != "Todos")
            {
                    string marcaBuscada = cbFiltroMarca.SelectedItem.ToString();
                    if (categoriaBuscada != "Todos")
                        filtradosPorCategoria = FiltrarCriterioDoble(marcaBuscada, categoriaBuscada);
                    else
                        filtradosPorCategoria = FiltrarPorMarca(marcaBuscada);
            }
                else
                {
                    filtradosPorCategoria = FiltrarPorCategoria(categoriaBuscada);
                }
                CargarDataGridView(filtradosPorCategoria);
            }
        }
        private void cbFiltroPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            int todos = 0, mayorAMenor = 1, menorAMayor = 2;

            if (cbFiltroPrecio.SelectedIndex == todos)
                InyectarArticulo();

            if (cbFiltroPrecio.SelectedIndex == mayorAMenor)
                InyectarArticulo(ConfigurationManager.AppSettings["queryOrdenarMayorAMenor"]);

            if (cbFiltroPrecio.SelectedIndex == menorAMayor)
                InyectarArticulo(ConfigurationManager.AppSettings["queryOrdenarMenorAMayor"]);
        }
        private void CargarComboBox()
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();

            cbFiltroMarca.DataSource = marca.Cargar();
            cbFiltroMarca.ValueMember = "Id";
            cbFiltroMarca.DisplayMember = "Descripcion";

            cbFiltroCategoria.DataSource = categoria.Cargar();
            cbFiltroCategoria.ValueMember = "Id";
            cbFiltroCategoria.DisplayMember = "Descripcion";

            cbFiltroPrecio.Items.Add("Todos");
            cbFiltroPrecio.Items.Add("Mayor a menor");
            cbFiltroPrecio.Items.Add("Menor a mayor");
            cbFiltroPrecio.SelectedIndex = 0;

            vistaInicializada = true;
        }
        private void OcultarColumnas()
        {
            dgvArticulos.Columns["Id"].Visible = false;
        }
        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscar.Clear();
            cbFiltroMarca.SelectedIndex = 0;
            cbFiltroCategoria.SelectedIndex = 0;
            cbFiltroPrecio.SelectedIndex = 0;
        }
        private List<Articulo> FiltrarPorNombre(string nombreBuscado)
        {
            List<Articulo> articulosBuscados;
            articulosBuscados = misArticulos.FindAll(articulo => articulo.Nombre.ToUpper().Contains(nombreBuscado));
            return articulosBuscados;
        }
        private List<Articulo> FiltrarPorMarca(string criterio)
        {
            List<Articulo> articuloFiltrado;

            if (criterio != "Todos")
                articuloFiltrado = misArticulos.FindAll(articulo => articulo.Marca.Descripcion == criterio);
            else
                articuloFiltrado = misArticulos;

            return articuloFiltrado;
        }
        private List<Articulo> FiltrarPorCategoria(string criterio)
        {
            List<Articulo> articuloFiltrado;

            if (criterio != "Todos")
                articuloFiltrado = misArticulos.FindAll(articulo => articulo.Categoria.Descripcion == criterio);
            else
                articuloFiltrado = misArticulos;

            return articuloFiltrado;
        }
        private List<Articulo> FiltrarCriterioDoble(string criterioMarca, string criterioCategoria)
        {
            List<Articulo> articulosFiltrados;

            articulosFiltrados = misArticulos.FindAll(articulo => (articulo.Marca.Descripcion == criterioMarca) && (articulo.Categoria.Descripcion == criterioCategoria));

            return articulosFiltrados;
        }
        private void CargarDataGridView(List<Articulo> articulosFiltrados)
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = articulosFiltrados;
            OcultarColumnas();
        }

        private void btnSiguienteImagen_Click(object sender, EventArgs e)
        {
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int cantidadImagenes = articuloActual.Imagen.Count();
            if (cantidadImagenes != 0)
            {
                indexImagen = (indexImagen + 1) % cantidadImagenes;
                helperVistas.CargarImagenDesdeArticulo(pbImagen, articuloActual, indexImagen);
            }
        }
        private void btnRetrocederImagen_Click(object sender, EventArgs e)
        {
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
            int cantidadImagenes = articuloActual.Imagen.Count();

            if (cantidadImagenes != 0)
            {
                indexImagen = (indexImagen - 1 + cantidadImagenes) % cantidadImagenes;
                helperVistas.CargarImagenDesdeArticulo(pbImagen, articuloActual, indexImagen);
            }   
        }
    }
}
