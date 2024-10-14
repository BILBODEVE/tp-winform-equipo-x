using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vistas
{
    internal class HelperVistas
    {
        public void CargarImagenDesdeArticulo(PictureBox picture, Articulo articulo, int index = 0)
        {
            try
            {
                picture.Load(articulo.Imagen[index]);
            }
            catch (Exception)
            {
                picture.Load("https://img.icons8.com/?size=100&id=1G2BW7-tQJJJ&format=png&color=000000");
            }
        }
       public void CargarURLImagen(PictureBox picture, string URLImagen)
        {
            try
            {
                picture.Load(URLImagen);
            }
            catch (Exception)
            {
                picture.Load("https://img.icons8.com/?size=100&id=1G2BW7-tQJJJ&format=png&color=000000");
            }
        }
    }
}
