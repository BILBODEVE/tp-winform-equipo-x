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
        public agregarMarca()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MarcaNegocio nuevaMarca = new MarcaNegocio();

            try
            {
                HelperNegocio validar = new HelperNegocio();
                string queryValidacion = "SELECT Descripcion FROM MARCAS";

                if(validar.ValidarCampo(txtNuevaMarca.Text))
                {
                    if(validar.ValidarNuevoItem(queryValidacion,txtNuevaMarca.Text))
                    {
                        nuevaMarca.Insertar(txtNuevaMarca.Text);
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
    }
}
