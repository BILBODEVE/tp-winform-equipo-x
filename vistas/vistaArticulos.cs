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
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            misArticulos = articuloNegocio.listar();
            dgvArticulos.DataSource = misArticulos;
            dgvArticulos.Columns["Descripcion"].Visible = false;
            dgvArticulos.Columns["Marca"].Visible = false;
            dgvArticulos.Columns["Categoria"].Visible = false;
            dgvArticulos.Columns["Precio"].Visible = false;
            dgvArticulos.Columns["URLImage"].Visible = false;
            CargarImagen(misArticulos[0].URLImage);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            Articulo articuloActual = (Articulo)dgvArticulos.CurrentRow.DataBoundItem; // Devuelve el objeto enlazado de la row
            CargarImagen(articuloActual.URLImage);
        }

        private void CargarImagen(string url)
        {
            try
            {
                pbImagen.Load(url);
            }
            catch (Exception ex)
            {
                pbImagen.Load("https://placehold.jp/150x150.png");
                //throw;
            }
        }
    }
}
