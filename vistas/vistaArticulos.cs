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
        public vistaArticulos()
        {
            InitializeComponent();
        }

        private void vistaArticulos_Load(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            List<Articulo> misArticulos = new List<Articulo>();
            misArticulos = articuloNegocio.listar();

            foreach (Articulo art in misArticulos)
            {
                int indiceRow = dgvArticulos.Rows.Add();
                dgvArticulos.Rows[indiceRow].Cells[0].Value = art.Codigo;
                dgvArticulos.Rows[indiceRow].Cells[1].Value = art.Nombre;
                dgvArticulos.Rows[indiceRow].Cells[2].Value = art.Descripcion;
            }
        }
    }
}
