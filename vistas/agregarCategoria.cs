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
            HelperNegocio validar = new HelperNegocio();
            string queryValidacion = "SELECT Descripcion FROM CATEGORIAS";

            try
            {
                if (validar.ValidarCampo(txtNuevaCategoria.Text))
                {
                    if(validar.ValidarNuevoItem(queryValidacion, txtNuevaCategoria.Text)) 
                    { 
                        nuevaCategoria.Insertar(txtNuevaCategoria.Text);
                        MessageBox.Show("La categoría " + txtNuevaCategoria.Text + " se agrego correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("La categoria que intenta ingresar ya existe en sistema.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre de categoria porfavor");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
