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
    public partial class agregarMarca : Form 
    {
        private MarcaNegocio marcaNegocio;
        private HelperNegocio helper;
        public agregarMarca()
        {
            InitializeComponent();
            marcaNegocio = new MarcaNegocio();
            helper = new HelperNegocio();
        }
        private void agregarMarca_Load(object sender, EventArgs e)
        {
            CargarComboBox(cbModificarMarca);
            CargarComboBox(cbEliminarMarca);
        }
        private void btnAgregarMarca_Click(object sender, EventArgs e)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HelperNegocio validar = new HelperNegocio();
                string queryValidacion = "SELECT Descripcion FROM MARCAS";

                if(validar.ValidarCampo(txtNuevaMarca.Text))
                {
                    if(validar.ValidarNuevoItem(queryValidacion,txtNuevaMarca.Text))
                    {
                        marcaNegocio.Insertar(txtNuevaMarca.Text);
                        MessageBox.Show("La marca " + txtNuevaMarca.Text + " se agrego correctamente!");
                    }
                    else
                    {
                        MessageBox.Show("La marca que intenta ingresar ya existe en el sistema.");
                    }
                }
                else
                {
                    MessageBox.Show("Ingrese un nombre de marca porfavor");
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
                comboBox.DataSource = marcaNegocio.Cargar();
                comboBox.ValueMember = "Id";
                comboBox.DisplayMember = "Descripcion";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnModificarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)cbModificarMarca.SelectedItem;
            marca.Descripcion = txtModificarMarca.Text;
            
            try
            {
                if (helper.ValidarCampo(marca.Descripcion))
                {
                    if (!marcaNegocio.ExisteRelacion(marca.Id))
                    {
                        marcaNegocio.Modificar(marca);
                        MessageBox.Show("La marca se actualizo correctamente.");    
                    }
                    else
                    {
                        MessageBox.Show("No es posible modificar la marca. Existen registros asociados.");
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Porfavor ingreso un nombre de marca.");
                    return;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            Marca marca = (Marca)cbEliminarMarca.SelectedItem;

            try
            {
                if (!marcaNegocio.ExisteRelacion(marca.Id))
                    marcaNegocio.EliminarFisica(marca);
                else
                {
                    MessageBox.Show("No es posible eliminar la marca. Existen registros asociados.");
                    return;
                }
                MessageBox.Show("La marca \"" + marca.Descripcion + "\" se elimino correctamente.");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
