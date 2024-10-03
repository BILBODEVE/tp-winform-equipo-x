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
    public partial class agregarCategoria : Form
    {
        private CategoriaNegocio categoriaNegocio;
        private HelperNegocio helper;

        public agregarCategoria()
        {
            InitializeComponent();
            categoriaNegocio = new CategoriaNegocio();
            helper = new HelperNegocio();
        }

        private void agregarCategoria_Load(object sender, EventArgs e)
        {
            CargarComboBox(cbModificarCategoria);
            CargarComboBox(cbEliminarCategoria);
        }
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            HelperNegocio validar = new HelperNegocio();
            string queryValidacion = "SELECT Descripcion FROM CATEGORIAS";

            try
            {
                if (validar.ValidarCampo(txtNuevaCategoria.Text))
                {
                    if(validar.ValidarNuevoItem(queryValidacion, txtNuevaCategoria.Text)) 
                    { 
                        categoriaNegocio.Insertar(txtNuevaCategoria.Text);
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
        private void CargarComboBox(System.Windows.Forms.ComboBox comboBox)
        {
            try
            {
                comboBox.DataSource = categoriaNegocio.Cargar();
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)cbModificarCategoria.SelectedItem;
            categoria.Descripcion = txtModificarCategoria.Text;

            try
            {
                if(helper.ValidarCampo(categoria.Descripcion))
                {
                    if (!categoriaNegocio.ExisteRelacion(categoria))
                    {
                        categoriaNegocio.Modificar(categoria);
                        MessageBox.Show("La categoria se actualizo correctamente.");

                    }
                    else
                    {
                        MessageBox.Show("No es posible modificar la categoría. Existen registros asociados.");
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre de categoria porfavor");
                    return;
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoria = (Categoria)cbEliminarCategoria.SelectedItem;

            try
            {
                if (!categoriaNegocio.ExisteRelacion(categoria))
                    categoriaNegocio.EliminarFisica(categoria);
                else
                {
                    MessageBox.Show("No es posible eliminar la categoria. Existen registros asociados.");
                    return;
                }
                MessageBox.Show("La categoria \"" + categoria.Descripcion + "\" se elimino correctamente.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
