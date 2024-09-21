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
                nuevaMarca.Insertar(txtNuevaMarca.Text);
                MessageBox.Show("La marca " + txtNuevaMarca.Text + " se agrego correctamente!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
