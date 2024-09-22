using dominio;
using negocio;
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
    public partial class confirmarAccion : Form
    {
        private Articulo articuloActual;
        public confirmarAccion()
        {
            InitializeComponent();
        }

        public confirmarAccion(Articulo articulo)
        {
            articuloActual = articulo;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();
            articuloNegocio.EliminarFisico(articuloActual);
            this.Close();
        }
    }
}
