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
    public partial class agregarCategoria : Form
    {
        public agregarCategoria()
        {
            InitializeComponent();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaNegocio nuevaCategoria = new CategoriaNegocio();

            try
            {
                nuevaCategoria.Insertar(txtNuevaCategoria.Text);
                MessageBox.Show("La categoría " + txtNuevaCategoria.Text + " se agrego correctamente!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
