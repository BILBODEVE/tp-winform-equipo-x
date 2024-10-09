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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace vistas
{
    public partial class agregarArticulo : Form
    {
        private Articulo articulo = null;
        private HelperNegocio helper;

        public agregarArticulo()
        {
            InitializeComponent();
            helper = new HelperNegocio();
        }
        public agregarArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio nuevoArticulo = new ArticuloNegocio();
            ImagenNegocio imagenNegocio = new ImagenNegocio();

            if (articulo == null)
                articulo = new Articulo();

            if (ValidarCamposRequeridos())
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marca)dpdMarca.SelectedItem;
                articulo.Categoria = (Categoria)dpdCategoria.SelectedItem;
                articulo.Imagen.Add(txtUrlImagen.Text);
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if (articulo.Id != 0)
                    nuevoArticulo.Modificar(articulo);
                else
                    nuevoArticulo.Cargar(articulo);

                MessageBox.Show("Operacion exitosa");
                LimpiarCampos();
            }
        }
        private void agregarArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marca = new MarcaNegocio();
            CategoriaNegocio categoria = new CategoriaNegocio();
            try
            {
                dpdMarca.DataSource = marca.Cargar();
                dpdMarca.ValueMember = "Id";
                dpdMarca.DisplayMember = "Descripcion";
                dpdCategoria.DataSource = categoria.Cargar();
                dpdCategoria.ValueMember = "Id";
                dpdCategoria.DisplayMember = "Descripcion";

                if (this.articulo != null)
                {
                    txtCodigo.Text = this.articulo.Codigo;
                    txtNombre.Text = this.articulo.Nombre;
                    txtDescripcion.Text = this.articulo.Descripcion;
                    dpdMarca.SelectedValue = this.articulo.Marca.Id;
                    dpdCategoria.SelectedValue = this.articulo.Categoria.Id;
                    txtUrlImagen.Text = this.articulo.Imagen[0];
                    txtPrecio.Text = this.articulo.Precio.ToString();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LimpiarCampos()
        {
            txtCodigo.Text = null;
            txtNombre.Text = null;
            txtDescripcion.Text = null;
            txtUrlImagen.Text = null;
            txtPrecio.Text = null;
        }

        private bool ValidarCampoNulo(System.Windows.Forms.TextBox TextBox)
        {
            if (string.IsNullOrEmpty(TextBox.Text))
            {
                errorProviderCodigo.SetError(TextBox, "El campo requiere un valor");
                return false;
            }
            else
            {
                errorProviderCodigo.SetError(TextBox, "");
                return true;
            }
        }
        private bool ValidarCampoNumerico(System.Windows.Forms.TextBox TextBox)
        {
            try
            {
                if (decimal.Parse(txtPrecio.Text) < 0)
                {
                    errorProviderCodigo.SetError(TextBox, "El precio no puede ser negativo");
                    return false;
                }
            }
            catch (Exception ex)
            {
                errorProviderCodigo.SetError(txtPrecio, "Ingrese un valor númerico adecuado");// Manejo de System.FormatException
            }
            return true;
        }
        private bool ValidarCamposRequeridos()
        {
            if (!ValidarCampoNulo(txtCodigo))
                return false;
            if (!ValidarCampoNulo(txtNombre))
                return false;
            if (!ValidarCampoNulo(txtUrlImagen))
                return false;
            if (!ValidarCampoNulo(txtPrecio) || !ValidarCampoNumerico(txtPrecio))
                return false;

            return true;
        }
    }
}
